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


namespace Andre_Milan
{
    
    public partial class Display : Form
    {
        public string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\27784\Desktop\CMPG212_Project\Andre_Milan\Andre_Milan\CoachDB.mdf;Integrated Security=True";
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;
        public SqlCommand cmd;
        public Display()
        {
            InitializeComponent();
        }

        //private void btnDisplay_Click(object sender, EventArgs e)
      //  {
     

       // }

        //private void Display_Load(object sender, EventArgs e)
        //{
           
        //}
        private void Vertoon()
        {
            conn.Open();
            SqlCommand com;
            string sql;
            adap = new SqlDataAdapter();
            ds = new DataSet();

            sql = @"Select * FROM tblCoach";
            com = new SqlCommand(sql, conn);

            adap.SelectCommand = com;
            adap.Fill(ds, "tblCoach");

            dbCoach.DataSource = ds;
            dbCoach.DataMember = "tblCoach";
            conn.Close();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Display_Load(object sender, EventArgs e)
        {
      
           
            conn = new SqlConnection(path);
            conn.Open();
            //MessageBox.Show("Connected Successfully");
            conn.Close();
            Vertoon();
        }
        private void Instant()
        {
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dbCoach.DataSource = bs;
            Vertoon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string dbFilter;
            dbFilter = cbSpesialize.Text;
            conn.Open();
            SqlCommand com;

            adap = new SqlDataAdapter();
            ds = new DataSet();

            com = new SqlCommand("SELECT * FROM tblCoach WHERE Spesialize='" + dbFilter + "'", conn);
            adap.SelectCommand = com;
            adap.Fill(ds, "Spesialize");

            dbCoach.DataSource = ds;
            dbCoach.DataMember = "Spesialize";
            conn.Close();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Bookings frmBook = new Bookings();
            frmBook.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string dbFilter = cbCoach.Text;

            try
            {
                string insert_query = "INSERT INTO tblCoach VALUES(@ID,@Coach,@Rating,@Spesialize,@Price)";
                conn = new SqlConnection(path);
                conn.Open();
                cmd = new SqlCommand(insert_query, conn);
                cmd.Parameters.AddWithValue(@"ID", 11);
                cmd.Parameters.AddWithValue(@"Coach", tbName.Text);
                cmd.Parameters.AddWithValue(@"Rating", tbRating.Text);
                cmd.Parameters.AddWithValue(@"Spesialize", cbCoach.Text);
                cmd.Parameters.AddWithValue(@"Price", tbPrice.Text);
                

                cmd.ExecuteNonQuery();
                conn.Close();
                Instant();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string delete_query = "DELETE FROM tblCoach WHERE ID = ' " + cbDelete.Text + "'";
                conn = new SqlConnection(path);
                conn.Open();
                cmd = new SqlCommand(delete_query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Instant();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);


            }
        }

        private void btnReDisplay_Click(object sender, EventArgs e)
        {
            Vertoon();
        }
    }

   // private void btnConnect_Click(object sender, EventArgs e)
      //  {
      //  }

        //private void btnBack_Click(object sender, EventArgs e)
       // {
           
       // }
    
}
