using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_menu_design
{
    public partial class frmItems : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-KU43MHN;database=CanteenManagement;trusted_connection=true");

        public frmItems()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text) ||
               string.IsNullOrWhiteSpace(txtName.Text) ||
               string.IsNullOrWhiteSpace(txtPrice.Text) ||
               PictureboxItem.Image == null)

            {
                MessageBox.Show("Please Full All Fields First");

            }
            else
            {

                Image img = Image.FromFile(openFileDialog1.FileName);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into Items values(@id,@name,@price,@pic)";
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@id", txtid.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value = ms.ToArray() });
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted Succesfully");
                con.Close();
                clearall();
            }

           
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                PictureboxItem.Image = img;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsid.Text))
            {
                MessageBox.Show("Please enter a valid Item ID first");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select *from Items where Itemid =" + txtsid.Text + "", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }


        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sds = new SqlDataAdapter("Select *from Items", con);
            DataTable dt = new DataTable();
            sds.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text) ||
              string.IsNullOrWhiteSpace(txtName.Text) ||
              string.IsNullOrWhiteSpace(txtPrice.Text) ||
              PictureboxItem.Image == null)

            {
                MessageBox.Show("Please Full All Fields First");

            }
            else
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);

                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE items SET Name = @name, Price = @price, Picture = @pic WHERE Itemid = @itemid";
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@itemid", txtid.Text);
                cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value = ms.ToArray() });

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data updated successfully");

                con.Close();
                clearall();

            }
           
        }
        public void clearall()
        {
            txtid.Clear();
            txtName.Clear();
            txtPrice.Clear();
            PictureboxItem.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from Items where Itemid=" + txtid.Text + "";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted SuccesFully");
            con.Close();
            clearall();
        }
    }
    }

