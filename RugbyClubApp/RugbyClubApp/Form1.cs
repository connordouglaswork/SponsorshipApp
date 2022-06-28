using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace RugbyClubApp
{
    public partial class Form1 : Form
    {
        string ConStr = @"Password=4044;Persist Security Info=True;User ID=sa;Initial Catalog=RugbyClub;Data Source=AUE135LT\SQLEXPRESS2014";
        public Form1()
        {
            InitializeComponent();

            RefreshTable();
        }

        public void RefreshTable()
        {
            var DataSource = new DataSet("Contributors");
            SqlConnection conn = new SqlConnection(ConStr);
            conn.Open();
            var DataAdapter = new SqlDataAdapter("SELECT [ContributorId],[Name],[JerseyNumber],[PhoneNumber],[Email],[Info],[Notes],[Amount],[RequestDate],[InvoiceDate],[RecieptDate],[Address],[Code],[Selected]  FROM [dbo].[Contributor]", conn);
            var dataTable = new DataTable();
            DataAdapter.Fill(dataTable);

            dataGridViewContributors.DataSource = dataTable;
            this.dataGridViewContributors.Name = "Contributors";
        }

        private void buttonAddContributors_Click(object sender, EventArgs e)
        {
            var conform = new Contributors();
            conform.Show();
        }

        private void buttonSendRequest_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConStr);
            conn.Open();
            var DataAdapter = new SqlDataAdapter("SELECT isnull(Max(RequestId),0) from Request", conn);
            var dataTable = new DataTable();
            int id = (int)DataAdapter.SelectCommand.ExecuteScalar();
            //int id = (int)dataTable.Rows[0][0];
            string TemplateDoc = AppContext.BaseDirectory + @"DOCS\Donation Request.docx";

            foreach (DataGridViewRow row in dataGridViewContributors.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    continue;
                }
                id++;
                string name = row.Cells[1].Value.ToString();
                string jerseynumber = row.Cells[2].Value.ToString();
                string phonenumber = row.Cells[3].Value.ToString();
                string email = row.Cells[4].Value.ToString();
                string info = row.Cells[5].Value.ToString();
                string notes = row.Cells[6].Value.ToString();
                string amount = row.Cells[7].Value.ToString();
                string address = row.Cells[8].Value.ToString();
                if (name == null)
                {
                    name = "";
                }
                if (jerseynumber == null)
                {
                    jerseynumber = "";
                }
                if (phonenumber == null)
                {
                    phonenumber = "";
                }
                if (email == null)
                {
                    email = "";
                }
                if (info == null)
                {
                    info = "";
                }
                if (notes == null)
                {
                    notes = "";
                }
                if (amount == null)
                {
                    amount = "";
                }
                if (address == null)
                {
                    address = "";
                }
                object filename = AppContext.BaseDirectory + @"OUTPUT\Donation_Request_" + name + "_" + DateTime.Now.Date.Year + "_" + DateTime.Now.Date.Month + "_" + DateTime.Now.Date.Day + ".docx";
                File.Copy(TemplateDoc, filename.ToString(), true);



                Word.Application wordApp = new Word.Application();
                object missing = Missing.Value;
                Word.Document myWordDoc = null;

                if (File.Exists((string)filename))
                {
                    object readOnly = false;
                    object isVisible = false;
                    wordApp.Visible = false;

                    myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);
                    myWordDoc.Activate();

                    //find and replace
                    this.FindAndReplace(wordApp, "<name>", name);
                    this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                    this.FindAndReplace(wordApp, "<id>", id);
                    this.FindAndReplace(wordApp, "<address>", address);
                    this.FindAndReplace(wordApp, "<description>", info);
                    this.FindAndReplace(wordApp, "<amount>", amount);
                    this.FindAndReplace(wordApp, "<comments>", notes);
                    myWordDoc.Save();
                    myWordDoc.Close();
                }
                else
                {
                    MessageBox.Show("File not Found!");
                }

            }
            


        }

        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rugbyClubDataSet.Contributor' table. You can move, or remove it, as needed.
            //this.contributorTableAdapter.Fill(this.rugbyClubDataSet.Contributor);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConStr);

            foreach (DataGridViewRow row in dataGridViewContributors.Rows)
            {
                if(row.Cells[0].Value == null)
                {
                    continue;
                }

                var name = row.Cells[1].Value;
                var jerseynumber = row.Cells[2].Value;
                var phonenumber = row.Cells[3].Value;
                var email = row.Cells[4].Value;
                var info = row.Cells[5].Value;
                var notes = row.Cells[6].Value;
                var amount = row.Cells[7].Value;
                if (row.Cells[7].Value.ToString() == "")
                {
                    amount = "0";
                }
                
                string contributorId = row.Cells[0].Value.ToString();
                string sql = "UPDATE [dbo].[Contributor] SET [Name] = '" + name + 
                                                         "', jerseynumber = " + jerseynumber +
                                                         ", phonenumber = '" + phonenumber + "'" +
                                                         ", email = '" + email + "'" +
                                                         ", info = '" + info + "'" +
                                                         ", notes = '" + notes + "'" +
                                                         ", amount = " + amount +
                                                         " WHERE CONTRIBUTORID = " + contributorId;

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    string msg = "Insert Error:";
                    msg += ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConStr);

            foreach (DataGridViewRow row in dataGridViewContributors.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    continue;
                }
                if (row.Cells[11].Value.ToString() != "True")
                {
                    continue;
                }

                string contributorId = row.Cells[0].Value.ToString();
                string sql = "DELETE FROM [dbo].[Contributor] WHERE CONTRIBUTORID = " + contributorId;

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    string msg = "Insert Error:";
                    msg += ex.Message;
                }
                finally
                {
                    conn.Close();
                }
                RefreshTable();

            }
            }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
    }

