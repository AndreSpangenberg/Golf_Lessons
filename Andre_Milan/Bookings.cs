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
    public partial class Bookings : Form
    {
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;
        public string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\27784\Desktop\CMPG212_Project\Andre_Milan\Andre_Milan\LessonsDB.mdf;Integrated Security=True";
        public SqlCommand cmd;
        public Bookings()
        {
            InitializeComponent();
        }

        private void Display()
        {
            conn.Open();
            SqlCommand com;
            string sql;
            adap = new SqlDataAdapter();
            ds = new DataSet();

            sql = @"Select * FROM tblBookings";
            com = new SqlCommand(sql, conn);

            adap.SelectCommand = com;
            adap.Fill(ds, "tblBookings");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tblBookings";
            conn.Close();
        }
        private void Instant()
        {
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            Display();
        }

        private void btnDisplayBookings_Click(object sender, EventArgs e)
        {
        
        
        }
        

        private void Bookings_Load(object sender, EventArgs e)
        {
            
            conn = new SqlConnection(path);
            conn.Open();
            //MessageBox.Show("Connected Successfully");
            conn.Close();
            Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string dbFilter = cbCoach.Text;

            try
            {
                string insert_query = "INSERT INTO tblBookings VALUES(@ID,@Name,@Surname,@Coach,@Date,@Time)";
                conn = new SqlConnection(path);
                conn.Open();
                cmd = new SqlCommand(insert_query, conn);
                cmd.Parameters.AddWithValue(@"ID", 6);
                cmd.Parameters.AddWithValue(@"Name", tbName.Text);
                cmd.Parameters.AddWithValue(@"Surname", tbSurname.Text);
                cmd.Parameters.AddWithValue(@"Coach", dbFilter);
                cmd.Parameters.AddWithValue(@"Date", tbDate.Text);
                cmd.Parameters.AddWithValue(@"Time", cbTime.Text);

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
                string delete_query = "DELETE FROM tblBookings WHERE ID = ' " + cbDelete.Text + "'";
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCoach_Click(object sender, EventArgs e)
        {
            Display frmDisplay = new Display();
            frmDisplay.ShowDialog();

        }
    }
}
