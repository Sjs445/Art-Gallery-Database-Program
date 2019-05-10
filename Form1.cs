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
using System.Data.Sql;


namespace CPSC_332_Assignment_5
{
    public partial class Form1 : Form
    {
        SqlConnection cnn;  //Global connection because we will pass it to the second form.

        public Form1()
        {
            InitializeComponent();
        }
        
        public bool createConnection()
        {
            string user = tb_Username.Text;
            string pass = tb_Password.Text;
            string connectionString;
            connectionString = "Data Source=localhost;Initial Catalog=Art Gallery;User ID=" + user + ";Password=" + pass;
            //Our connection string to our database. Note the user must be an authenticated sql user.
            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                DialogResult result = MessageBox.Show("Login Successful.", "Success", MessageBoxButtons.OK);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong username or password!");
                return false;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(isEmpty())
            {
                return;
            }
            if(createConnection()==true)    //If the connection is successful we open a new form and pass the SQL connection to the new form in the constructor.
            {
                this.Hide();
                Main mainForm = new Main(cnn);
                mainForm.ShowDialog();
                this.Close();
            }
        }

        public bool isEmpty()
        {
            if(tb_Username.Text=="")
            {
                MessageBox.Show("Please enter a username.\n", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (tb_Password.Text == "")
            {
                MessageBox.Show("Please enter a password.\n", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Art Gallery Database.\nPlease login with your username and password to proceed.\n", "Welcome");
        }
    }
}
