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
    public partial class frmOrderEntry : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-KU43MHN;database=CanteenManagement;trusted_connection=true");
        public frmOrderEntry()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
        public void Loadproduct()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select *from Items",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbproduct.DataSource = dt;
            cmbproduct.ValueMember = "Itemid";
            cmbproduct.DisplayMember = "Name";
            con.Close();

        }

        private void PanelEmployeefrom_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void frmOrderEntry_Load(object sender, EventArgs e)
        {
            Loadproduct();
            Autopriceload();


        }
        private void Autopriceload()
        {
            //object productid = cmbproduct.SelectedValue;
            //int id = Convert.ToInt32(productid);


            //con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("select itemid,price from Items where Itemid =@id",con);
            
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //cmbprice.ValueMember = "itemid";
            //cmbprice.DisplayMember = "price";
            //con.Close();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Orders WHERE DAY(Orderdate) = @Day AND MONTH(Orderdate) = @Month AND YEAR(Orderdate) = @Year", con);
            sda.SelectCommand.Parameters.AddWithValue("@Day", datetimepickershowOrder.Value.Day);
            sda.SelectCommand.Parameters.AddWithValue("@Month", datetimepickershowOrder.Value.Month);
            sda.SelectCommand.Parameters.AddWithValue("@Year", datetimepickershowOrder.Value.Year);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select *FROM Orders ",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
