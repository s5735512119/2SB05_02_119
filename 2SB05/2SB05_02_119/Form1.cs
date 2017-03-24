using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace _2SB05_02_119
{
    public partial class Form1 : Form
    {
        public string conString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=2SB05Person.mdb;Persist Security Info=False";
        OleDbConnection con = null;
        DataSet dSet = null;
        OleDbDataAdapter dAdapter = null;
        CurrencyManager currManager = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (con == null)
            {
                try
                {
                    con = new OleDbConnection(conString);
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                    con = null;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Already connected!");
                return;
            }
            MessageBox.Show("Connected!");
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (con != null)
            {
                try
                {
                    con.Close();
                    con = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Closed!");
        }

        private void btPopulate_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(conString))
            {
                using (var cmd = new OleDbCommand("Select * from PersonTable", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;

                    var da = new OleDbDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            /*dSet = new DataSet();
            dAdapter = new OleDbDataAdapter("select * from PersonTable",con);
            dAdapter.Fill(dSet, "PersonTable");
            this.dataGridView1.DataSource = dSet.Tables["PersonTable"];*/
            txtName.DataBindings.Add("Text", dSet.Tables["PersonTable"],"FirstName");
            //txtSurname.DataBindings.Add("Text", dSet.Tables["PersonTable"],"LastName");
           // txtTitle.DataBindings.Add("Text", dSet.Tables["PersonTable"], "Title");
            //txtCity.DataBindings.Add("Text", dSet.Tables["PersonTable"], "City");
            //txtCountry.DataBindings.Add("Text", dSet.Tables["PersonTable"], "Country");
            //currManager = (CurrencyManager)this.BindingContext[dSet.Tables["PersonTable"]];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currManager.Position += 1;
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            currManager.Position -= 1;
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert;
                strInsert = "insert into PersonTable(FirstName, LastName,Title, City, Country)"
                + " values('" + this.txtName.Text + "', '"
                + this.txtSurname.Text + "', '"
                + this.txtTitle.Text + "', '"
                + this.txtCity.Text + "', '"
                + this.txtCountry.Text + "')";
                if (this.txtName.Text != "" && this.txtSurname.Text != "")
                {
                    OleDbCommand dbCommand1 = new OleDbCommand(strInsert,
                    this.con);
                    dbCommand1.CommandType = CommandType.Text;
                    dbCommand1.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Error...", "WARNING",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ", " WARNING ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string strDel="DELETE FROM PersonTable WHERE FirstName =('" + this.txtName.Text + "')";
                if (this.txtName.Text != "" && this.txtSurname.Text != "")
                {
                    OleDbCommand dbCommand1 = new OleDbCommand(strDel,
                    this.con);
                    dbCommand1.CommandType = CommandType.Text;
                    dbCommand1.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Error...", "WARNING",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ", " WARNING ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
        }

		private void btRefresh_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = 0;
		}
	}
}
