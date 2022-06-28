namespace RugbyClubApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAddContributors = new System.Windows.Forms.Button();
            this.buttonSendRequest = new System.Windows.Forms.Button();
            this.buttonSendInvoice = new System.Windows.Forms.Button();
            this.buttonSendRecipt = new System.Windows.Forms.Button();
            this.dataGridViewContributors = new System.Windows.Forms.DataGridView();
            this.contributorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.rugbyClubDataSet = new RugbyClubApp.RugbyClubDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContributors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contributorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rugbyClubDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddContributors
            // 
            this.buttonAddContributors.Location = new System.Drawing.Point(23, 27);
            this.buttonAddContributors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddContributors.Name = "buttonAddContributors";
            this.buttonAddContributors.Size = new System.Drawing.Size(193, 45);
            this.buttonAddContributors.TabIndex = 0;
            this.buttonAddContributors.Text = "Add Contributors";
            this.buttonAddContributors.UseVisualStyleBackColor = true;
            this.buttonAddContributors.Click += new System.EventHandler(this.buttonAddContributors_Click);
            // 
            // buttonSendRequest
            // 
            this.buttonSendRequest.Location = new System.Drawing.Point(23, 523);
            this.buttonSendRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSendRequest.Name = "buttonSendRequest";
            this.buttonSendRequest.Size = new System.Drawing.Size(193, 45);
            this.buttonSendRequest.TabIndex = 1;
            this.buttonSendRequest.Text = "Send Request";
            this.buttonSendRequest.UseVisualStyleBackColor = true;
            this.buttonSendRequest.Click += new System.EventHandler(this.buttonSendRequest_Click);
            // 
            // buttonSendInvoice
            // 
            this.buttonSendInvoice.Location = new System.Drawing.Point(23, 599);
            this.buttonSendInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSendInvoice.Name = "buttonSendInvoice";
            this.buttonSendInvoice.Size = new System.Drawing.Size(193, 45);
            this.buttonSendInvoice.TabIndex = 2;
            this.buttonSendInvoice.Text = "Send Invoice";
            this.buttonSendInvoice.UseVisualStyleBackColor = true;
            // 
            // buttonSendRecipt
            // 
            this.buttonSendRecipt.Location = new System.Drawing.Point(23, 671);
            this.buttonSendRecipt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSendRecipt.Name = "buttonSendRecipt";
            this.buttonSendRecipt.Size = new System.Drawing.Size(193, 45);
            this.buttonSendRecipt.TabIndex = 3;
            this.buttonSendRecipt.Text = "Send Receipt";
            this.buttonSendRecipt.UseVisualStyleBackColor = true;
            // 
            // dataGridViewContributors
            // 
            this.dataGridViewContributors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContributors.Location = new System.Drawing.Point(242, 27);
            this.dataGridViewContributors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewContributors.Name = "dataGridViewContributors";
            this.dataGridViewContributors.Size = new System.Drawing.Size(1951, 689);
            this.dataGridViewContributors.TabIndex = 4;
            // 
            // contributorBindingSource
            // 
            this.contributorBindingSource.DataSource = this.rugbyClubDataSet;
            this.contributorBindingSource.Position = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(23, 160);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(193, 45);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save Contributors";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(23, 235);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(193, 45);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Remove Contributors";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(23, 90);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(193, 45);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "Refresh Table";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // rugbyClubDataSet
            // 
            this.rugbyClubDataSet.DataSetName = "RugbyClubDataSet";
            this.rugbyClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2209, 737);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewContributors);
            this.Controls.Add(this.buttonSendRecipt);
            this.Controls.Add(this.buttonSendInvoice);
            this.Controls.Add(this.buttonSendRequest);
            this.Controls.Add(this.buttonAddContributors);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContributors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contributorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rugbyClubDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddContributors;
        private System.Windows.Forms.Button buttonSendRequest;
        private System.Windows.Forms.Button buttonSendInvoice;
        private System.Windows.Forms.Button buttonSendRecipt;
        private System.Windows.Forms.DataGridView dataGridViewContributors;
        private System.Windows.Forms.BindingSource contributorBindingSource;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRefresh;
        private RugbyClubDataSet rugbyClubDataSet;
    }
}

