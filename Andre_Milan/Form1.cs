using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andre_Milan
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        //private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            

        //}

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpAndSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help_Support helpSupport = new Help_Support();
            helpSupport.ShowDialog();
            
           
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Display frmDisplay = new Display();
            frmDisplay.Show();
        }

        private void searchLessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please make sure you viewed the coaches prices before booking a lesson!");
            Bookings bk = new Bookings();
            bk.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
