//Shane Spangenberg
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace CPSC_332_Assignment_5
{
    public partial class Main : Form
    {
        SqlConnection cnn;
        public Main(SqlConnection cnn)
        {
            this.cnn = cnn;
            InitializeComponent();
        }
        SqlCommand cmd, cmd2;
        SqlDataReader dr;

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        public void sqlQuery(string command)
        {
            cmd = new SqlCommand(command, cnn);
            cmd.ExecuteNonQuery();
        }

        public void sqlQuery2(string command)
        {
            cmd2 = new SqlCommand(command, cnn);
            cmd2.ExecuteNonQuery();
        }

        private void btn_Displayrecord_Click(object sender, EventArgs e)
        {
            if(cb_Records.Text=="Record")
            {
                MessageBox.Show("Choose a record!");
                return;
            }

            listView1.View = View.Details;
            listView1.Columns.Clear();  //Each time we click Display record button we want to clear the data in the list view.
            listView1.Items.Clear();
            cb_Sort.Items.Clear();      //We also want to clear the Sort Items Combo Box
            string cbData = SetTable(cb_Records.Text);  //Set the string cbData to our actual table name.
            cmd2 = new SqlCommand("select column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE table_Name='" + cbData + "';", cnn);    //This command gets the table names

            cmd = new SqlCommand("select * from [" + cbData + "];", cnn);   //This command retrieves all the data in the table
            dr = cmd2.ExecuteReader();

            while(dr.Read())    //Read in the columns and populate the list view with the column names.
            {
                
                string Col = dr.GetString(0);
                listView1.Columns.Add(Col);
                cb_Sort.Items.Add(Col);

            }
            dr.Close();
            int numofColumns = listView1.Columns.Count; //Get the size of the columns.

            dr = cmd.ExecuteReader();

            while(dr.Read())    //Read all the data in the table and populate the list view.
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = dr[0].ToString();
                for(int i=1; i<numofColumns; i++)
                {
                    lvItem.SubItems.Add(dr[i].ToString());
                }
                listView1.Items.Add(lvItem);
            }
           
            dr.Close();
            allignColumns();

        }

        public void allignColumns()
        {
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].Width = -2;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {   //Prints the Data in the list view to a text file called data.txt
            using (StreamWriter sw = new StreamWriter("data.txt"))
            {
                StringBuilder sb;
                if (listView1.Items.Count > 0)
                {
                    foreach (ListViewItem lvi in listView1.Items)
                    {
                        sb = new StringBuilder();

                        foreach (ListViewItem.ListViewSubItem listViewSubItem in lvi.SubItems)
                        {
                            sb.Append(string.Format("{0}\t", listViewSubItem.Text));
                        }
                        sw.WriteLine(sb.ToString());
                    }
                    sw.WriteLine();
                    MessageBox.Show("Printed information successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("No data to print!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            if(cb_Sort.Text=="Sort By")
            {
                MessageBox.Show("Please select an attribute to sort by!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            listView1.View = View.Details;
            int numofColumns = listView1.Columns.Count;
            string table = SetTable(cb_Records.Text);
            cmd = new SqlCommand("select * from[" + table + "] order by ["+ cb_Sort.Text +"] asc;", cnn);   //We are running the same query but now sorting in asc order.
            dr = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (dr.Read())    //Read all the data in the table and populate the list view.
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = dr[0].ToString();
                for (int i = 1; i < numofColumns; i++)
                {
                    lvItem.SubItems.Add(dr[i].ToString());
                }
                listView1.Items.Add(lvItem);
            }
            dr.Close();
            allignColumns();
        }

        public string SetTable(string table)   //Here we are converting english to our actual table names
        {
            if(table=="Artist")
            {
                return "ARTIST";
            }
            else if(table=="Contact Info")
            {
                return "Contact_Info";
            }
            else if(table=="Customer")
            {
                return "Customer";
            }
            if(table=="Location Info")
            {
                return "location_info";
            }
            else if(table=="Preferences")
            {
                return "Art_Preferences";
            }
            else if(table=="Shows")
            {
                return "Art_Shows";
            }
            else if(table=="Style")
            {
                return "Art_Style";
            }
            else if(table=="Work")
            {
                return "Art_Work";
            }
            else
            {
                return "INVALID";
            }
        }
    }
}
