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

namespace Simple_menu_design
{
    public partial class frmSales : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-KU43MHN;database=CanteenManagement;trusted_connection=true");

        public frmSales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM Sales WHERE Saledate BETWEEN "+dateTimePickerfrom.Value+" AND "+dateTimePickerto.Value+"",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DatagridshowSales.DataSource = dt;
            con.Close();

            
          
            
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *from Sales",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DatagridshowSales.DataSource = dt;
            con.Close();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PanelEmployeefrom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtid.Text)||
                string.IsNullOrWhiteSpace(txtsale.Text))
            {
                MessageBox.Show("Please Fill Up All Fielda First");
            }
            else if(datetimesale.Value >= DateTime.Now)
            {
                MessageBox.Show("You Can't Insert value for Advance Time");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into sales ( saleId,Saledate,TotalSale) values(@saleid,@date,@total)";


                cmd.Parameters.AddWithValue("@saleid", txtid.Text);
                cmd.Parameters.AddWithValue("@date", datetimesale.Value);
                cmd.Parameters.AddWithValue("@total", txtsale.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Succesfully");
                con.Close();
                clear();

            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtid.Text))
              
            {
                MessageBox.Show("Please Fill Up All field First");
            }
            else if (datetimesale.Value >= DateTime.Now)
            {
                MessageBox.Show("You Can't Insert value for Advance Time");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " update sales set saleid=@id,saledate=@date,TotalSale=@totalsale where saleid="+txtid.Text+"";
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@id", txtid.Text);
                cmd.Parameters.AddWithValue("@date", datetimesale.Value);
                cmd.Parameters.AddWithValue("@totalsale", txtsale.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Succesfully");
                con.Close();
                clear();
            }
            
        }
        private void clear()
        {
            txtid.Clear();
            txtsale.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text))
            {
                MessageBox.Show("Plese Enter a valid SaleId");
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from sales where saleid=" + txtid.Text + "";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Succesfully");
            con.Close();
            clear();
        }
    }
}
