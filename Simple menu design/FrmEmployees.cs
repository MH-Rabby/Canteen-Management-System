using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Simple_menu_design
{
    public partial class FrmEmployees : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-KU43MHN;database=CanteenManagement;trusted_connection=true");
        public FrmEmployees()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtfname.Text) ||
                string.IsNullOrWhiteSpace(txtmname.Text) ||
                string.IsNullOrWhiteSpace(txtMail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtSecondNo.Text) ||
                string.IsNullOrWhiteSpace(txtPreAddress.Text) ||
                string.IsNullOrWhiteSpace(txtParmanentAdd.Text) ||
                string.IsNullOrWhiteSpace(txtsalary.Text) ||
                cmbGender.SelectedValue == null ||
                PictureboxEmp.Image == null ||
                cmbDesignation.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all fields.");
            }

            else if (txtPhone.Text.Length > 11 || txtSecondNo.Text.Length > 11)
            {
                MessageBox.Show("One or both phone numbers exceed 11 digits.");
            }

            else
            {
                // Load image from file
                Image img = Image.FromFile(openFileDialog1.FileName);
                // Save image to MemoryStream
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"INSERT INTO Employees(EmployeesId, Name, FathersName, MothersName, Email, PhoneNo, AlternativePhNo, PresentAddress, ParmanentAddress, GenderId, Picture, Designationid, JoiningDate, Salary) VALUES(@id, @name, @faname, @mName, @email, @phone, @alterph, @preAdd, @parAdd, @gen, @pic, @des, @join, @salary)";
                cmd.Connection = con;

                //parameters
                cmd.Parameters.AddWithValue("@id", txtid.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@faname", txtfname.Text);
                cmd.Parameters.AddWithValue("@mName", txtmname.Text);
                cmd.Parameters.AddWithValue("@email", txtMail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@alterph", txtSecondNo.Text);
                cmd.Parameters.AddWithValue("@preAdd", txtPreAddress.Text);
                cmd.Parameters.AddWithValue("@parAdd", txtParmanentAdd.Text);
                cmd.Parameters.AddWithValue("@gen", cmbGender.SelectedValue);
                cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value = ms.ToArray() });
                cmd.Parameters.AddWithValue("@des", cmbDesignation.SelectedValue);
                cmd.Parameters.AddWithValue("@join", datetimepickeEmployee.Value);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDecimal(txtsalary.Text));

                // Execute  command
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Inserted Successfully");
                clr();
            }
           

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                PictureboxEmp.Image = img;
            }

        }
        private void loadgender()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *from gender",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbGender.DataSource = dt;
            cmbGender.ValueMember = "Genderid";
            cmbGender.DisplayMember = "GenderName";
            con.Close();
        }
        private void loadDesignation()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select *from Designation",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbDesignation.DataSource = dt;
            cmbDesignation.ValueMember = "DesignationId";
            cmbDesignation.DisplayMember = "DesignationName";
            con.Close();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            loadgender();
            loadDesignation();
        }

        private void PanelEmployeefrom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *from Employees",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *from employees where employeesId ="+ txtemid.Text+"",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void clr()
        {
            txtid.Clear();
            txtName.Clear();
            txtfname.Clear();
            txtmname.Clear();
            txtMail.Clear();
            txtPhone.Clear();
            txtSecondNo.Clear();
            txtParmanentAdd.Clear();
            txtPreAddress.Clear();
            PictureboxEmp.Image =null;
            txtsalary.Clear();

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            { 

            }
            

        }
    }
    
}
