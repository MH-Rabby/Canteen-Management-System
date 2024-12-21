using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_menu_design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnitem_Click(object sender, EventArgs e)
        {
            Loadform(new frmItems());
        }

        private void panelfill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Loadform( object Form)
        {
            if(this.panelmain.Controls.Count>0)           
               this.panelmain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock= DockStyle.Fill;
            this.panelmain.Controls.Add(f);
            this.panelmain.Tag= f;
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnhome_Click_1(object sender, EventArgs e)
        {
           

        }

        private void btnitem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Loadform(new FrmEmployees());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loadform(new frmregistation());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loadform(new frmOrderEntry());
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            Loadform(new frmSales());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loadform( new frmAddGoods());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Loadform(new frmAboutus());
        }
    }
    
}
