namespace ITI.presentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cb_manger = new ComboBox();
            txt_location = new TextBox();
            txt_description = new TextBox();
            txt_name = new TextBox();
            dgv_departments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_departments).BeginInit();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(522, 111);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 23;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(522, 63);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 22;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(522, 24);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 21;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 71);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 20;
            label4.Text = "Manger";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 16);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 19;
            label3.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 72);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 18;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 18);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // cb_manger
            // 
            cb_manger.FormattingEnabled = true;
            cb_manger.Location = new Point(337, 69);
            cb_manger.Name = "cb_manger";
            cb_manger.Size = new Size(121, 23);
            cb_manger.TabIndex = 16;
            // 
            // txt_location
            // 
            txt_location.Location = new Point(337, 15);
            txt_location.Name = "txt_location";
            txt_location.Size = new Size(121, 23);
            txt_location.TabIndex = 15;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(112, 69);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(121, 23);
            txt_description.TabIndex = 14;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(113, 12);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(121, 23);
            txt_name.TabIndex = 13;
            // 
            // dgv_departments
            // 
            dgv_departments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_departments.Location = new Point(12, 140);
            dgv_departments.Name = "dgv_departments";
            dgv_departments.Size = new Size(587, 185);
            dgv_departments.TabIndex = 12;
            dgv_departments.RowHeaderMouseDoubleClick += dgv_departments_RowHeaderMouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 335);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_manger);
            Controls.Add(txt_location);
            Controls.Add(txt_description);
            Controls.Add(txt_name);
            Controls.Add(dgv_departments);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_departments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_delete;
        private Button btn_edit;
        private Button btn_add;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cb_manger;
        private TextBox txt_location;
        private TextBox txt_description;
        private TextBox txt_name;
        private DataGridView dgv_departments;
    }
}
