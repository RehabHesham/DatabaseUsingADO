using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ConnectedMode
{
    public partial class Students : Form
    {
        // 1) define connection string
        //SqlConnection con = new SqlConnection();
        ////con.ConnectionString = "Server= DESKTOP-7T759QG";
        //con.ConnectionString = "Server= .; Database=iti; Trusted_Connection=True; TrustServerCertificate=True";

        SqlConnection con = new SqlConnection("Server= .; Database=iti; Trusted_Connection=True; TrustServerCertificate=True");

        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {

            GetStudents();
            GetDepartments();

            btn_edit.Visible = false;
            btn_delete.Visible = false;
        }

        private void GetStudents()
        {
            // 2) define sql command
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select [St_Id],[St_Fname],[St_Lname],[St_Address],[St_Age],[Dept_Id] from [dbo].[Student]";
            //cmd.Connection = con;

            SqlCommand cmd = new SqlCommand("select [St_Id],[St_Fname],[St_Lname],[St_Address],[St_Age],[Dept_Id] from [dbo].[Student]", con);

            // 3) open connection
            con.Open();

            // 4) execute command
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            // List<Student> students = new List<Student>();
            //while(reader.Read()){
            //    // read data row by row
            //    // convert each row to object
            //    Student std = new Student();
            //    std.Id = (int)reader["St_Id"];
            //    std.Fname = (string)reader["St_Fname"];
            //    std.Lname = (string)reader["St_Lname"];
            //    std.Address = (string)reader["St_Address"];
            //    std.Age = (int)reader["St_Age"];
            //    std.DeptId = (int)reader["Dept_Id"];
            //    students.Add(std);
            //}

            // 6) close connection
            con.Close();



            // 5) display results
            dgv_students.DataSource = dt;
        }

        private void GetDepartments()
        {
            // define command
            SqlCommand cmd = new SqlCommand("select [Dept_Id],[Dept_Name] from [dbo].[Department]", con);

            // open connection
            con.Open();

            // execute command
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);


            // close connection
            con.Close();


            // display results
            // combox
            cb_department.DataSource = dt;
            cb_department.DisplayMember = "Dept_Name";
            cb_department.ValueMember = "Dept_Id";

            //cb_department.SelectedValue => dept id
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"insert into [dbo].[Student]([St_Fname],[St_Lname],[St_Address],[St_Age],[Dept_Id]) values('{txt_fname.Text}','{txt_lname.Text}','{txt_address.Text}',{nud_age.Value.ToString()},{cb_department.SelectedValue.ToString()})", con);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();


            if (rowsAffected > 0)
            {
                MessageBox.Show("Student Added Successfully");
                GetStudents();
            }
            else
            {
                MessageBox.Show("Error Try Again");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"update [dbo].[Student] set [St_Fname]= @fname, [St_Lname]=@lname, [St_Address]=@address, [St_Age]=@age, [Dept_Id]=@dept  where [St_Id] = @id", con);
            cmd.Parameters.AddWithValue("fname", txt_fname.Text);
            cmd.Parameters.AddWithValue("lname", txt_lname.Text);
            cmd.Parameters.AddWithValue("address", txt_address.Text);
            cmd.Parameters.AddWithValue("age", nud_age.Value);
            cmd.Parameters.AddWithValue("dept", cb_department.SelectedValue);
            cmd.Parameters.AddWithValue("id", Selected_Id);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Student Updated Successfully");
                GetStudents();
            }
            else
            {
                MessageBox.Show("Error Try Again");
            }

            btn_edit.Visible = false;
            btn_delete.Visible = false;
            btn_add.Visible = true;
            // clear form
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_address.Text = "";
            nud_age.Value = 0;
            cb_department.SelectedIndex = -1;
        }

        int Selected_Id = 0;
        private void dgv_students_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridViewRow row = dgv_students.Rows[e.RowIndex];
            DataGridViewRow row = dgv_students.SelectedRows[0];
            Selected_Id = (int)row.Cells["St_Id"].Value;
            txt_fname.Text = row.Cells["St_Fname"].Value.ToString();
            txt_lname.Text = row.Cells["St_Lname"].Value.ToString();
            txt_address.Text = row.Cells["St_Address"].Value.ToString();
            nud_age.Value = (int)row.Cells["St_Age"].Value;
            cb_department.SelectedValue = (int)row.Cells["Dept_Id"].Value;

            btn_edit.Visible = true;
            btn_delete.Visible = true;
            btn_add.Visible = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"delete from [dbo].[Student]  where [St_Id] = {Selected_Id}", con);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Student Deleted Successfully");
                GetStudents();
            }
            else
            {
                MessageBox.Show("Error Try Again");
            }
        }
    }
}
