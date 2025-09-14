using ITI.Business;
using ITI.Business.Models;

namespace ITI.presentation
{
    public partial class Form1 : Form
    {
        DepartmentService departmentService = new DepartmentService();
        InstructorService instructorService = new InstructorService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_departments.DataSource = departmentService.GetAll();

            cb_manger.DataSource = instructorService.GetAsManger();
            cb_manger.DisplayMember = "Ins_Name";
            cb_manger.ValueMember = "Ins_Id";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Department department = new Department()
            {
                DeptName = txt_name.Text,
                DeptDesc = txt_description.Text,
                DeptLocation = txt_location.Text,
                DeptManager = (int)cb_manger.SelectedValue
            };
            int res = departmentService.Insert(department);
            if (res > 0)
            {
                MessageBox.Show("Added");
                dgv_departments.DataSource = departmentService.GetAll();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Department department = new Department()
            {
                DeptId = selectedId,
                DeptName = txt_name.Text,
                DeptDesc = txt_description.Text,
                DeptLocation = txt_location.Text,
                DeptManager = (int)cb_manger.SelectedValue
            };
            int res = departmentService.Update(department);
            if (res > 0)
            {
                MessageBox.Show("Updated");
                dgv_departments.DataSource = departmentService.GetAll();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        int selectedId = 0;
        private void dgv_departments_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgv_departments.SelectedRows[0];
            selectedId = (int)row.Cells[0].Value;
            txt_name.Text = row.Cells[1].Value.ToString();
            txt_description.Text = row.Cells[2].Value.ToString();
            txt_location.Text = row.Cells[3].Value.ToString();
            cb_manger.SelectedValue = (int)row.Cells[4].Value;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int res = departmentService.Delete(selectedId);
            if (res > 0)
            {
                MessageBox.Show("Deleted");
                dgv_departments.DataSource = departmentService.GetAll();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
