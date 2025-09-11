namespace ConnectedMode
{
    partial class Students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_students = new DataGridView();
            txt_fname = new TextBox();
            txt_lname = new TextBox();
            txt_address = new TextBox();
            nud_age = new NumericUpDown();
            cb_department = new ComboBox();
            lbl_fname = new Label();
            lbl_lname = new Label();
            lbl_address = new Label();
            lbl_age = new Label();
            lbl_department = new Label();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            SuspendLayout();
            // 
            // dgv_students
            // 
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_students.Location = new Point(12, 150);
            dgv_students.Name = "dgv_students";
            dgv_students.Size = new Size(652, 212);
            dgv_students.TabIndex = 0;
            dgv_students.RowHeaderMouseDoubleClick += dgv_students_RowHeaderMouseDoubleClick;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(105, 27);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(121, 23);
            txt_fname.TabIndex = 1;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(105, 65);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(121, 23);
            txt_lname.TabIndex = 2;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(105, 103);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(121, 23);
            txt_address.TabIndex = 3;
            // 
            // nud_age
            // 
            nud_age.Location = new Point(325, 31);
            nud_age.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(121, 23);
            nud_age.TabIndex = 4;
            // 
            // cb_department
            // 
            cb_department.FormattingEnabled = true;
            cb_department.Location = new Point(325, 90);
            cb_department.Name = "cb_department";
            cb_department.Size = new Size(121, 23);
            cb_department.TabIndex = 5;
            // 
            // lbl_fname
            // 
            lbl_fname.AutoSize = true;
            lbl_fname.Location = new Point(56, 33);
            lbl_fname.Name = "lbl_fname";
            lbl_fname.Size = new Size(43, 15);
            lbl_fname.TabIndex = 6;
            lbl_fname.Text = "Fname";
            // 
            // lbl_lname
            // 
            lbl_lname.AutoSize = true;
            lbl_lname.Location = new Point(56, 71);
            lbl_lname.Name = "lbl_lname";
            lbl_lname.Size = new Size(43, 15);
            lbl_lname.TabIndex = 7;
            lbl_lname.Text = "Lname";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(55, 109);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(49, 15);
            lbl_address.TabIndex = 8;
            lbl_address.Text = "Address";
            // 
            // lbl_age
            // 
            lbl_age.AutoSize = true;
            lbl_age.Location = new Point(240, 37);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(28, 15);
            lbl_age.TabIndex = 9;
            lbl_age.Text = "Age";
            // 
            // lbl_department
            // 
            lbl_department.AutoSize = true;
            lbl_department.Location = new Point(240, 93);
            lbl_department.Name = "lbl_department";
            lbl_department.Size = new Size(70, 15);
            lbl_department.TabIndex = 10;
            lbl_department.Text = "Department";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(524, 30);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 11;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(524, 65);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 12;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(524, 100);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 374);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(lbl_department);
            Controls.Add(lbl_age);
            Controls.Add(lbl_address);
            Controls.Add(lbl_lname);
            Controls.Add(lbl_fname);
            Controls.Add(cb_department);
            Controls.Add(nud_age);
            Controls.Add(txt_address);
            Controls.Add(txt_lname);
            Controls.Add(txt_fname);
            Controls.Add(dgv_students);
            Name = "Students";
            Text = "Students";
            Load += Students_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_students;
        private TextBox txt_fname;
        private TextBox txt_lname;
        private TextBox txt_address;
        private NumericUpDown nud_age;
        private ComboBox cb_department;
        private Label lbl_fname;
        private Label lbl_lname;
        private Label lbl_address;
        private Label lbl_age;
        private Label lbl_department;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
    }
}