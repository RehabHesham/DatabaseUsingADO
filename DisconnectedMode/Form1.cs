using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace DisconnectedMode
{
    public partial class Form1 : Form
    {
        // define connection 
        SqlConnection con = new SqlConnection("Server= .; Database=iti; Trusted_Connection=True; TrustServerCertificate=True");
        // define data adapter
        SqlDataAdapter da = new SqlDataAdapter();
        // define data table
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getDepartments();
            getManger();
        }

        private void getManger()
        {
            SqlCommand cmd = new SqlCommand("select [Ins_Id],[Ins_Name] from [dbo].[Instructor]", con);

            da.SelectCommand = cmd;

            DataTable mangers = new DataTable();
            da.Fill(mangers);

            cb_manger.DataSource = mangers;
            cb_manger.DisplayMember = "Ins_Name";
            cb_manger.ValueMember = "Ins_Id";
        }

        int lastId = 0;
        private void getDepartments()
        {
            // Phase 1: Getting Data

            // define select command
            SqlCommand selectCmd = new SqlCommand("select [Dept_Id],[Dept_Name],[Dept_Desc],[Dept_Location],[Dept_Manager] from [dbo].[Department]", con);

            // attach select command to data adapter
            da.SelectCommand = selectCmd;

            // get data
            da.Fill(dt);

            // bind data to grid view
            dgv_departments.DataSource = dt;

            lastId = (int)dt.Rows[dt.Rows.Count - 1]["Dept_Id"];
            dt.Columns["Dept_Id"].Unique = true;
            dt.Columns["Dept_Id"].AllowDBNull = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();

            dr["Dept_Id"] = ++lastId;
            dr["Dept_Name"] = txt_name.Text;
            dr["Dept_Desc"] = txt_description.Text;
            dr["Dept_Location"] = txt_location.Text;
            dr["Dept_Manager"] = cb_manger.SelectedValue;

            dt.Rows.Add(dr);
        }

        int selectecId = 0;
        private void btn_edit_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if ((int)dr["Dept_Id"] == selectecId)
                {
                    dr["Dept_Name"] = txt_name.Text;
                    dr["Dept_Desc"] = txt_description.Text;
                    dr["Dept_Location"] = txt_location.Text;
                    dr["Dept_Manager"] = cb_manger.SelectedValue;
                    break;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("=======================");
            foreach (DataRow dr in dt.Rows)
            {
                Debug.WriteLine($"State: {dr.RowState}");
            }

            // Phase 3: Saving Data
            // define insert command
            SqlCommand insCmd = new SqlCommand("insert into [dbo].[Department] ([Dept_Name],[Dept_Desc],[Dept_Location],[Dept_Manager]) values(@name,@desc,@loc,@manger)", con);
            insCmd.Parameters.Add("@name",SqlDbType.NVarChar, 50, "Dept_Name");
            insCmd.Parameters.Add("@desc",SqlDbType.NVarChar, 100, "Dept_Desc");
            insCmd.Parameters.Add("@loc",SqlDbType.NVarChar, 50, "Dept_Location");
            insCmd.Parameters.Add("@manger",SqlDbType.Int, 4, "Dept_Manager");

            SqlCommand updateCmd = new SqlCommand("update [dbo].[Department] set [Dept_Name]=@name, [Dept_Desc]= @desc, [Dept_Location]= @loc, [Dept_Manager]=@manger where [Dept_Id]=@id", con);
            updateCmd.Parameters.Add("@name", SqlDbType.NVarChar, 50, "Dept_Name");
            updateCmd.Parameters.Add("@desc", SqlDbType.NVarChar, 100, "Dept_Desc");
            updateCmd.Parameters.Add("@loc", SqlDbType.NVarChar, 50, "Dept_Location");
            updateCmd.Parameters.Add("@manger", SqlDbType.Int, 4, "Dept_Manager");
            updateCmd.Parameters.Add("@id", SqlDbType.Int, 4, "Dept_Id");

            SqlCommand deleteCmd = new SqlCommand("delete from [dbo].[Department] where [Dept_Id]=@id", con);
            deleteCmd.Parameters.Add("@id", SqlDbType.Int, 4, "Dept_Id");

            // attach commands to data adapter
            da.InsertCommand = insCmd;
            da.UpdateCommand = updateCmd;
            da.DeleteCommand = deleteCmd;

            // save data
            da.Update(dt);

            // refresh data
            dt.Clear();
            getDepartments();
        }
    }
}
