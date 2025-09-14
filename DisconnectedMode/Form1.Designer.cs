namespace DisconnectedMode
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
            dgv_departments = new DataGridView();
            txt_name = new TextBox();
            txt_description = new TextBox();
            txt_location = new TextBox();
            cb_manger = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_add = new Button();
            btn_edit = new Button();
            btn_save = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_departments).BeginInit();
            SuspendLayout();
            // 
            // dgv_departments
            // 
            dgv_departments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_departments.Location = new Point(12, 153);
            dgv_departments.Name = "dgv_departments";
            dgv_departments.Size = new Size(587, 185);
            dgv_departments.TabIndex = 0;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(113, 25);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(121, 23);
            txt_name.TabIndex = 1;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(112, 82);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(121, 23);
            txt_description.TabIndex = 2;
            // 
            // txt_location
            // 
            txt_location.Location = new Point(337, 28);
            txt_location.Name = "txt_location";
            txt_location.Size = new Size(121, 23);
            txt_location.TabIndex = 3;
            // 
            // cb_manger
            // 
            cb_manger.FormattingEnabled = true;
            cb_manger.Location = new Point(337, 82);
            cb_manger.Name = "cb_manger";
            cb_manger.Size = new Size(121, 23);
            cb_manger.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 31);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 85);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 29);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 84);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 8;
            label4.Text = "Manger";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(522, 37);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 9;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(522, 80);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 10;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(522, 123);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 11;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 350);
            Controls.Add(btn_save);
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

        private DataGridView dgv_departments;
        private TextBox txt_name;
        private TextBox txt_description;
        private TextBox txt_location;
        private ComboBox cb_manger;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_save;
    }
}
