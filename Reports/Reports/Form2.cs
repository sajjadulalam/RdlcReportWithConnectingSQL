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

namespace Reports
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\OneDrive\Documents\EmployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("Insert Into dbo.Employee2 Values (@Id, @Name, @Designation, @Religion, @Blood, @DOB, @Gender)", con);
            cmd.Connection = con;
            con.Open();

            cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Designation", txtDes.Text);
            cmd.Parameters.AddWithValue("@Religion", txtRel.Text);
            cmd.Parameters.AddWithValue("@Blood", txtBlood.Text);
            cmd.Parameters.AddWithValue("@DOB", DateTime.Parse(dob.Text));

            string gender = "";
            string skills = "";
            if (true)
            {

            }

            if (male.Checked == true)
            {
                gender = male.Text;
            }
            else if (female.Checked == true)
            {
                gender = female.Text;
            }
            else
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            cmd.Parameters.AddWithValue("@Gender", gender);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\OneDrive\Documents\EmployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("UPDATE dbo.Employee2 SET Name = @Name, Designation = @Designation, Religion = @Religion, Blood = @Blood, DOB = @DOB, Gender = @Gender WHERE Id = @Id",con);

            con.Open();
            cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Designation", txtDes.Text);
            cmd.Parameters.AddWithValue("@Religion", txtRel.Text);
            cmd.Parameters.AddWithValue("@Blood", txtBlood.Text);
            cmd.Parameters.AddWithValue("@DOB", DateTime.Parse(dob.Text));

            string gender = "";
            if (male.Checked == true)
            {
                gender = male.Text;
            }
            else if (female.Checked == true)
            {
                gender = female.Text;
            }
            cmd.Parameters.AddWithValue("@Gender", gender);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successfully");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\OneDrive\Documents\EmployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("Delete dbo.Employee2 WHERE Id = @Id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Successfully");
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
