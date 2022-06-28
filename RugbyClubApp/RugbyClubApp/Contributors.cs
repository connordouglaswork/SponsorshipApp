using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RugbyClubApp
{
    public partial class Contributors : Form
    {
        string ConStr = @"Password=4044;Persist Security Info=True;User ID=sa;Initial Catalog=RugbyClub;Data Source=AUE135LT\SQLEXPRESS2014";

        public Contributors()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string jersey = textBoxJerseyNumber.Text;
            string phone = textBoxPhoneNumber.Text;
            string email = textBoxEmail.Text;
            string info = textBoxInfo.Text;
            string notes = textBoxNotes.Text;
            
            SqlConnection conn = new SqlConnection(ConStr);


            string sql = "INSERT INTO [dbo].[Contributor]([Name],[JerseyNumber],[PhoneNumber],[Email],[Info],[Notes])VALUES('" + name + "'," + jersey + ",'" + phone + "','" + email + "','" + info + "','" + notes + "')";

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
}


