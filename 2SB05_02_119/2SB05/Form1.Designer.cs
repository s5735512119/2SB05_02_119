namespace _2SB05_02_119
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btPopulate = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.btNext = new System.Windows.Forms.Button();
			this.btPrevious = new System.Windows.Forms.Button();
			this.btAddNew = new System.Windows.Forms.Button();
			this.btDelete = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.City = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(12, 276);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 0;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Location = new System.Drawing.Point(584, 276);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
			this.btnDisconnect.TabIndex = 1;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridView1.Size = new System.Drawing.Size(647, 258);
			this.dataGridView1.TabIndex = 2;
			// 
			// btPopulate
			// 
			this.btPopulate.Location = new System.Drawing.Point(93, 276);
			this.btPopulate.Name = "btPopulate";
			this.btPopulate.Size = new System.Drawing.Size(75, 23);
			this.btPopulate.TabIndex = 3;
			this.btPopulate.Text = "Populate";
			this.btPopulate.UseVisualStyleBackColor = true;
			this.btPopulate.Click += new System.EventHandler(this.btPopulate_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(322, 305);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 4;
			// 
			// txtSurname
			// 
			this.txtSurname.Location = new System.Drawing.Point(512, 305);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(100, 20);
			this.txtSurname.TabIndex = 5;
			// 
			// btNext
			// 
			this.btNext.Location = new System.Drawing.Point(336, 276);
			this.btNext.Name = "btNext";
			this.btNext.Size = new System.Drawing.Size(75, 23);
			this.btNext.TabIndex = 6;
			this.btNext.Text = "Next >>";
			this.btNext.UseVisualStyleBackColor = true;
			this.btNext.Click += new System.EventHandler(this.button1_Click);
			// 
			// btPrevious
			// 
			this.btPrevious.Location = new System.Drawing.Point(255, 276);
			this.btPrevious.Name = "btPrevious";
			this.btPrevious.Size = new System.Drawing.Size(75, 23);
			this.btPrevious.TabIndex = 7;
			this.btPrevious.Text = "<< Previous";
			this.btPrevious.UseVisualStyleBackColor = true;
			this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
			// 
			// btAddNew
			// 
			this.btAddNew.Location = new System.Drawing.Point(441, 332);
			this.btAddNew.Name = "btAddNew";
			this.btAddNew.Size = new System.Drawing.Size(75, 23);
			this.btAddNew.TabIndex = 8;
			this.btAddNew.Text = "New Record";
			this.btAddNew.UseVisualStyleBackColor = true;
			this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
			// 
			// btDelete
			// 
			this.btDelete.Location = new System.Drawing.Point(537, 332);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(75, 23);
			this.btDelete.TabIndex = 9;
			this.btDelete.Text = "Del Record";
			this.btDelete.UseVisualStyleBackColor = true;
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(248, 308);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(438, 308);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Surname";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(62, 308);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Title";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(136, 305);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(100, 20);
			this.txtTitle.TabIndex = 13;
			// 
			// City
			// 
			this.City.AutoSize = true;
			this.City.Location = new System.Drawing.Point(62, 334);
			this.City.Name = "City";
			this.City.Size = new System.Drawing.Size(24, 13);
			this.City.TabIndex = 14;
			this.City.Text = "City";
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(136, 331);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(100, 20);
			this.txtCity.TabIndex = 15;
			// 
			// txtCountry
			// 
			this.txtCountry.Location = new System.Drawing.Point(322, 334);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(100, 20);
			this.txtCountry.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(248, 337);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Country";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 364);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCountry);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.City);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.btAddNew);
			this.Controls.Add(this.btPrevious);
			this.Controls.Add(this.btNext);
			this.Controls.Add(this.txtSurname);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btPopulate);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.btnConnect);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btPopulate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPrevious;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label4;
	}
}

