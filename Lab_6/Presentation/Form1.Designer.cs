
namespace Presentation
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
            this.groupsGrid = new System.Windows.Forms.DataGridView();
            this.studentsGrid = new System.Windows.Forms.DataGridView();
            this.curatorsGrid = new System.Windows.Forms.DataGridView();
            this.add_student_btn = new System.Windows.Forms.Button();
            this.student_id_tb = new System.Windows.Forms.TextBox();
            this.student_name_tb = new System.Windows.Forms.TextBox();
            this.student_age_tb = new System.Windows.Forms.TextBox();
            this.student_groupId_tb = new System.Windows.Forms.TextBox();
            this.add_group_btn = new System.Windows.Forms.Button();
            this.add_curator_btn = new System.Windows.Forms.Button();
            this.delete_student_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.update_student = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.group_delete_btn = new System.Windows.Forms.Button();
            this.group_name_tb = new System.Windows.Forms.TextBox();
            this.group_id_tb = new System.Windows.Forms.TextBox();
            this.update_curator_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.curator_delete_btn = new System.Windows.Forms.Button();
            this.curator_groupId_tb = new System.Windows.Forms.TextBox();
            this.curator_email_tb = new System.Windows.Forms.TextBox();
            this.curator_name_tb = new System.Windows.Forms.TextBox();
            this.curator_id_tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.count_group_by_id_tb = new System.Windows.Forms.TextBox();
            this.count_group_btn = new System.Windows.Forms.Button();
            this.group_count_label = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.curator_by_student_tb = new System.Windows.Forms.TextBox();
            this.curator_by_student_btn = new System.Windows.Forms.Button();
            this.curator_by_student_label = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.avg_age_by_curator_tb = new System.Windows.Forms.TextBox();
            this.avg_age_by_curator_btn = new System.Windows.Forms.Button();
            this.avg_age_by_curator_label = new System.Windows.Forms.Label();
            this.All_students = new System.Windows.Forms.Button();
            this.group_count = new System.Windows.Forms.Label();
            this.group_countt = new System.Windows.Forms.TextBox();
            this.get_curator_name = new System.Windows.Forms.Button();
            this.сurators_name = new System.Windows.Forms.TextBox();
            this.get_average_age = new System.Windows.Forms.Button();
            this.av_age = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curatorsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupsGrid
            // 
            this.groupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsGrid.Location = new System.Drawing.Point(17, 70);
            this.groupsGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupsGrid.Name = "groupsGrid";
            this.groupsGrid.RowHeadersWidth = 62;
            this.groupsGrid.RowTemplate.Height = 25;
            this.groupsGrid.Size = new System.Drawing.Size(667, 253);
            this.groupsGrid.TabIndex = 1;
            this.groupsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupsGrid_CellContentClick);
            // 
            // studentsGrid
            // 
            this.studentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGrid.Location = new System.Drawing.Point(17, 399);
            this.studentsGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentsGrid.Name = "studentsGrid";
            this.studentsGrid.RowHeadersWidth = 62;
            this.studentsGrid.RowTemplate.Height = 25;
            this.studentsGrid.Size = new System.Drawing.Size(667, 232);
            this.studentsGrid.TabIndex = 2;
            // 
            // curatorsGrid
            // 
            this.curatorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.curatorsGrid.Location = new System.Drawing.Point(13, 712);
            this.curatorsGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curatorsGrid.Name = "curatorsGrid";
            this.curatorsGrid.RowHeadersWidth = 62;
            this.curatorsGrid.RowTemplate.Height = 25;
            this.curatorsGrid.Size = new System.Drawing.Size(667, 223);
            this.curatorsGrid.TabIndex = 3;
            // 
            // add_student_btn
            // 
            this.add_student_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_student_btn.Location = new System.Drawing.Point(1077, 399);
            this.add_student_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_student_btn.Name = "add_student_btn";
            this.add_student_btn.Size = new System.Drawing.Size(114, 183);
            this.add_student_btn.TabIndex = 4;
            this.add_student_btn.Text = "Add Student";
            this.add_student_btn.UseVisualStyleBackColor = true;
            this.add_student_btn.Click += new System.EventHandler(this.add_student_btn_Click);
            // 
            // student_id_tb
            // 
            this.student_id_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.student_id_tb.Location = new System.Drawing.Point(1249, 405);
            this.student_id_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.student_id_tb.Name = "student_id_tb";
            this.student_id_tb.Size = new System.Drawing.Size(79, 39);
            this.student_id_tb.TabIndex = 5;
            this.student_id_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // student_name_tb
            // 
            this.student_name_tb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.student_name_tb.Location = new System.Drawing.Point(824, 410);
            this.student_name_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.student_name_tb.Name = "student_name_tb";
            this.student_name_tb.Size = new System.Drawing.Size(239, 45);
            this.student_name_tb.TabIndex = 6;
            this.student_name_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // student_age_tb
            // 
            this.student_age_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.student_age_tb.Location = new System.Drawing.Point(824, 475);
            this.student_age_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.student_age_tb.Name = "student_age_tb";
            this.student_age_tb.Size = new System.Drawing.Size(239, 39);
            this.student_age_tb.TabIndex = 7;
            this.student_age_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // student_groupId_tb
            // 
            this.student_groupId_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.student_groupId_tb.Location = new System.Drawing.Point(824, 534);
            this.student_groupId_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.student_groupId_tb.Name = "student_groupId_tb";
            this.student_groupId_tb.Size = new System.Drawing.Size(239, 39);
            this.student_groupId_tb.TabIndex = 8;
            this.student_groupId_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add_group_btn
            // 
            this.add_group_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_group_btn.Location = new System.Drawing.Point(1077, 70);
            this.add_group_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_group_btn.Name = "add_group_btn";
            this.add_group_btn.Size = new System.Drawing.Size(103, 183);
            this.add_group_btn.TabIndex = 9;
            this.add_group_btn.Text = "Add Group";
            this.add_group_btn.UseVisualStyleBackColor = true;
            this.add_group_btn.Click += new System.EventHandler(this.add_group_btn_Click);
            // 
            // add_curator_btn
            // 
            this.add_curator_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_curator_btn.Location = new System.Drawing.Point(1077, 712);
            this.add_curator_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_curator_btn.Name = "add_curator_btn";
            this.add_curator_btn.Size = new System.Drawing.Size(103, 183);
            this.add_curator_btn.TabIndex = 10;
            this.add_curator_btn.Text = "Add Curator";
            this.add_curator_btn.UseVisualStyleBackColor = true;
            this.add_curator_btn.Click += new System.EventHandler(this.add_curator_btn_Click);
            // 
            // delete_student_btn
            // 
            this.delete_student_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete_student_btn.Location = new System.Drawing.Point(1204, 475);
            this.delete_student_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete_student_btn.Name = "delete_student_btn";
            this.delete_student_btn.Size = new System.Drawing.Size(154, 48);
            this.delete_student_btn.TabIndex = 11;
            this.delete_student_btn.Text = "Delete by ID";
            this.delete_student_btn.UseVisualStyleBackColor = true;
            this.delete_student_btn.Click += new System.EventHandler(this.delete_student_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(711, 419);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(711, 478);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(711, 537);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Group ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1204, 410);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID";
            // 
            // update_student
            // 
            this.update_student.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.update_student.Location = new System.Drawing.Point(1204, 534);
            this.update_student.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update_student.Name = "update_student";
            this.update_student.Size = new System.Drawing.Size(154, 48);
            this.update_student.TabIndex = 16;
            this.update_student.Text = "Update by ID";
            this.update_student.UseVisualStyleBackColor = true;
            this.update_student.Click += new System.EventHandler(this.update_student_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1204, 205);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 48);
            this.button2.TabIndex = 27;
            this.button2.Text = "Update by ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.update_group_btn);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1204, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 32);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(727, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 32);
            this.label8.TabIndex = 23;
            this.label8.Text = "Name";
            // 
            // group_delete_btn
            // 
            this.group_delete_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_delete_btn.Location = new System.Drawing.Point(1204, 147);
            this.group_delete_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_delete_btn.Name = "group_delete_btn";
            this.group_delete_btn.Size = new System.Drawing.Size(143, 48);
            this.group_delete_btn.TabIndex = 22;
            this.group_delete_btn.Text = "Delete by ID";
            this.group_delete_btn.UseVisualStyleBackColor = true;
            this.group_delete_btn.Click += new System.EventHandler(this.group_delete_btn_Click);
            // 
            // group_name_tb
            // 
            this.group_name_tb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_name_tb.Location = new System.Drawing.Point(824, 140);
            this.group_name_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_name_tb.Name = "group_name_tb";
            this.group_name_tb.Size = new System.Drawing.Size(228, 45);
            this.group_name_tb.TabIndex = 19;
            this.group_name_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // group_id_tb
            // 
            this.group_id_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_id_tb.Location = new System.Drawing.Point(1249, 77);
            this.group_id_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_id_tb.Name = "group_id_tb";
            this.group_id_tb.Size = new System.Drawing.Size(68, 39);
            this.group_id_tb.TabIndex = 18;
            this.group_id_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // update_curator_btn
            // 
            this.update_curator_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.update_curator_btn.Location = new System.Drawing.Point(1204, 847);
            this.update_curator_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update_curator_btn.Name = "update_curator_btn";
            this.update_curator_btn.Size = new System.Drawing.Size(143, 48);
            this.update_curator_btn.TabIndex = 38;
            this.update_curator_btn.Text = "Update by ID";
            this.update_curator_btn.UseVisualStyleBackColor = true;
            this.update_curator_btn.Click += new System.EventHandler(this.update_curator_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1204, 724);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 32);
            this.label6.TabIndex = 37;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(711, 850);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 32);
            this.label7.TabIndex = 36;
            this.label7.Text = "Group ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(711, 792);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 32);
            this.label9.TabIndex = 35;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(711, 733);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 32);
            this.label10.TabIndex = 34;
            this.label10.Text = "Name";
            // 
            // curator_delete_btn
            // 
            this.curator_delete_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.curator_delete_btn.Location = new System.Drawing.Point(1204, 789);
            this.curator_delete_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curator_delete_btn.Name = "curator_delete_btn";
            this.curator_delete_btn.Size = new System.Drawing.Size(143, 48);
            this.curator_delete_btn.TabIndex = 33;
            this.curator_delete_btn.Text = "Delete by ID";
            this.curator_delete_btn.UseVisualStyleBackColor = true;
            this.curator_delete_btn.Click += new System.EventHandler(this.curator_delete_btn_Click);
            // 
            // curator_groupId_tb
            // 
            this.curator_groupId_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.curator_groupId_tb.Location = new System.Drawing.Point(824, 847);
            this.curator_groupId_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curator_groupId_tb.Name = "curator_groupId_tb";
            this.curator_groupId_tb.Size = new System.Drawing.Size(228, 39);
            this.curator_groupId_tb.TabIndex = 32;
            this.curator_groupId_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // curator_email_tb
            // 
            this.curator_email_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.curator_email_tb.Location = new System.Drawing.Point(824, 789);
            this.curator_email_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curator_email_tb.Name = "curator_email_tb";
            this.curator_email_tb.Size = new System.Drawing.Size(228, 39);
            this.curator_email_tb.TabIndex = 31;
            this.curator_email_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // curator_name_tb
            // 
            this.curator_name_tb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.curator_name_tb.Location = new System.Drawing.Point(824, 724);
            this.curator_name_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curator_name_tb.Name = "curator_name_tb";
            this.curator_name_tb.Size = new System.Drawing.Size(228, 45);
            this.curator_name_tb.TabIndex = 30;
            this.curator_name_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // curator_id_tb
            // 
            this.curator_id_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.curator_id_tb.Location = new System.Drawing.Point(1249, 719);
            this.curator_id_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curator_id_tb.Name = "curator_id_tb";
            this.curator_id_tb.Size = new System.Drawing.Size(68, 39);
            this.curator_id_tb.TabIndex = 29;
            this.curator_id_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(294, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 45);
            this.label11.TabIndex = 39;
            this.label11.Text = "Groups";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(294, 349);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 45);
            this.label12.TabIndex = 40;
            this.label12.Text = "Students";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(294, 662);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 45);
            this.label13.TabIndex = 41;
            this.label13.Text = "Curators";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(33, 1193);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 32);
            this.label14.TabIndex = 42;
            this.label14.Text = "Group ID";
            // 
            // count_group_by_id_tb
            // 
            this.count_group_by_id_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count_group_by_id_tb.Location = new System.Drawing.Point(146, 1193);
            this.count_group_by_id_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.count_group_by_id_tb.Name = "count_group_by_id_tb";
            this.count_group_by_id_tb.Size = new System.Drawing.Size(83, 39);
            this.count_group_by_id_tb.TabIndex = 43;
            this.count_group_by_id_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // count_group_btn
            // 
            this.count_group_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count_group_btn.Location = new System.Drawing.Point(239, 1193);
            this.count_group_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.count_group_btn.Name = "count_group_btn";
            this.count_group_btn.Size = new System.Drawing.Size(186, 48);
            this.count_group_btn.TabIndex = 44;
            this.count_group_btn.Text = "Count group by ID";
            this.count_group_btn.UseVisualStyleBackColor = true;
            this.count_group_btn.Click += new System.EventHandler(this.count_group_btn_Click);
            // 
            // group_count_label
            // 
            this.group_count_label.AutoSize = true;
            this.group_count_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_count_label.Location = new System.Drawing.Point(491, 1200);
            this.group_count_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.group_count_label.Name = "group_count_label";
            this.group_count_label.Size = new System.Drawing.Size(29, 40);
            this.group_count_label.TabIndex = 45;
            this.group_count_label.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(20, 1278);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 32);
            this.label15.TabIndex = 46;
            this.label15.Text = "Student ID";
            // 
            // curator_by_student_tb
            // 
            this.curator_by_student_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.curator_by_student_tb.Location = new System.Drawing.Point(146, 1273);
            this.curator_by_student_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curator_by_student_tb.Name = "curator_by_student_tb";
            this.curator_by_student_tb.Size = new System.Drawing.Size(83, 39);
            this.curator_by_student_tb.TabIndex = 47;
            this.curator_by_student_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // curator_by_student_btn
            // 
            this.curator_by_student_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.curator_by_student_btn.Location = new System.Drawing.Point(239, 1273);
            this.curator_by_student_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curator_by_student_btn.Name = "curator_by_student_btn";
            this.curator_by_student_btn.Size = new System.Drawing.Size(244, 48);
            this.curator_by_student_btn.TabIndex = 48;
            this.curator_by_student_btn.Text = "Get Curator by Student ID";
            this.curator_by_student_btn.UseVisualStyleBackColor = true;
            this.curator_by_student_btn.Click += new System.EventHandler(this.curator_by_student_btn_Click);
            // 
            // curator_by_student_label
            // 
            this.curator_by_student_label.AutoSize = true;
            this.curator_by_student_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.curator_by_student_label.Location = new System.Drawing.Point(491, 1280);
            this.curator_by_student_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curator_by_student_label.Name = "curator_by_student_label";
            this.curator_by_student_label.Size = new System.Drawing.Size(29, 40);
            this.curator_by_student_label.TabIndex = 49;
            this.curator_by_student_label.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(617, 1193);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 32);
            this.label16.TabIndex = 50;
            this.label16.Text = "Curator ID";
            // 
            // avg_age_by_curator_tb
            // 
            this.avg_age_by_curator_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avg_age_by_curator_tb.Location = new System.Drawing.Point(743, 1188);
            this.avg_age_by_curator_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avg_age_by_curator_tb.Name = "avg_age_by_curator_tb";
            this.avg_age_by_curator_tb.Size = new System.Drawing.Size(83, 39);
            this.avg_age_by_curator_tb.TabIndex = 51;
            this.avg_age_by_curator_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // avg_age_by_curator_btn
            // 
            this.avg_age_by_curator_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avg_age_by_curator_btn.Location = new System.Drawing.Point(849, 1188);
            this.avg_age_by_curator_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avg_age_by_curator_btn.Name = "avg_age_by_curator_btn";
            this.avg_age_by_curator_btn.Size = new System.Drawing.Size(296, 48);
            this.avg_age_by_curator_btn.TabIndex = 52;
            this.avg_age_by_curator_btn.Text = "Get avg age by curator";
            this.avg_age_by_curator_btn.UseVisualStyleBackColor = true;
            this.avg_age_by_curator_btn.Click += new System.EventHandler(this.avg_age_by_curator_btn_Click);
            // 
            // avg_age_by_curator_label
            // 
            this.avg_age_by_curator_label.AutoSize = true;
            this.avg_age_by_curator_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avg_age_by_curator_label.Location = new System.Drawing.Point(1169, 1200);
            this.avg_age_by_curator_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.avg_age_by_curator_label.Name = "avg_age_by_curator_label";
            this.avg_age_by_curator_label.Size = new System.Drawing.Size(29, 40);
            this.avg_age_by_curator_label.TabIndex = 53;
            this.avg_age_by_curator_label.Text = "-";
            // 
            // All_students
            // 
            this.All_students.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.All_students.Location = new System.Drawing.Point(1429, 70);
            this.All_students.Name = "All_students";
            this.All_students.Size = new System.Drawing.Size(174, 125);
            this.All_students.TabIndex = 54;
            this.All_students.Text = "Количество студентов";
            this.All_students.UseVisualStyleBackColor = true;
            this.All_students.Click += new System.EventHandler(this.All_students_Click);
            // 
            // group_count
            // 
            this.group_count.AutoSize = true;
            this.group_count.Location = new System.Drawing.Point(1499, 298);
            this.group_count.Name = "group_count";
            this.group_count.Size = new System.Drawing.Size(0, 25);
            this.group_count.TabIndex = 55;
            this.group_count.Click += new System.EventHandler(this.label17_Click);
            // 
            // group_countt
            // 
            this.group_countt.Location = new System.Drawing.Point(1429, 222);
            this.group_countt.Name = "group_countt";
            this.group_countt.Size = new System.Drawing.Size(174, 31);
            this.group_countt.TabIndex = 56;
            // 
            // get_curator_name
            // 
            this.get_curator_name.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.get_curator_name.Location = new System.Drawing.Point(1429, 405);
            this.get_curator_name.Name = "get_curator_name";
            this.get_curator_name.Size = new System.Drawing.Size(174, 102);
            this.get_curator_name.TabIndex = 57;
            this.get_curator_name.Text = "Имя куратора ";
            this.get_curator_name.UseVisualStyleBackColor = true;
            this.get_curator_name.Click += new System.EventHandler(this.get_curator_name_Click);
            // 
            // сurators_name
            // 
            this.сurators_name.Location = new System.Drawing.Point(1429, 551);
            this.сurators_name.Name = "сurators_name";
            this.сurators_name.Size = new System.Drawing.Size(174, 31);
            this.сurators_name.TabIndex = 58;
            // 
            // get_average_age
            // 
            this.get_average_age.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.get_average_age.Location = new System.Drawing.Point(1429, 719);
            this.get_average_age.Name = "get_average_age";
            this.get_average_age.Size = new System.Drawing.Size(174, 115);
            this.get_average_age.TabIndex = 59;
            this.get_average_age.Text = "Средний возраст";
            this.get_average_age.UseVisualStyleBackColor = true;
            this.get_average_age.Click += new System.EventHandler(this.get_average_age_Click);
            // 
            // av_age
            // 
            this.av_age.Location = new System.Drawing.Point(1429, 864);
            this.av_age.Name = "av_age";
            this.av_age.Size = new System.Drawing.Size(174, 31);
            this.av_age.TabIndex = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1633, 977);
            this.Controls.Add(this.av_age);
            this.Controls.Add(this.get_average_age);
            this.Controls.Add(this.сurators_name);
            this.Controls.Add(this.get_curator_name);
            this.Controls.Add(this.group_countt);
            this.Controls.Add(this.group_count);
            this.Controls.Add(this.All_students);
            this.Controls.Add(this.avg_age_by_curator_label);
            this.Controls.Add(this.avg_age_by_curator_btn);
            this.Controls.Add(this.avg_age_by_curator_tb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.curator_by_student_label);
            this.Controls.Add(this.curator_by_student_btn);
            this.Controls.Add(this.curator_by_student_tb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.group_count_label);
            this.Controls.Add(this.count_group_btn);
            this.Controls.Add(this.count_group_by_id_tb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.update_curator_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.curator_delete_btn);
            this.Controls.Add(this.curator_groupId_tb);
            this.Controls.Add(this.curator_email_tb);
            this.Controls.Add(this.curator_name_tb);
            this.Controls.Add(this.curator_id_tb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.group_delete_btn);
            this.Controls.Add(this.group_name_tb);
            this.Controls.Add(this.group_id_tb);
            this.Controls.Add(this.update_student);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_student_btn);
            this.Controls.Add(this.add_curator_btn);
            this.Controls.Add(this.add_group_btn);
            this.Controls.Add(this.student_groupId_tb);
            this.Controls.Add(this.student_age_tb);
            this.Controls.Add(this.student_name_tb);
            this.Controls.Add(this.student_id_tb);
            this.Controls.Add(this.add_student_btn);
            this.Controls.Add(this.curatorsGrid);
            this.Controls.Add(this.studentsGrid);
            this.Controls.Add(this.groupsGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Lab6";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curatorsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView groupsGrid;
        private System.Windows.Forms.DataGridView studentsGrid;
        private System.Windows.Forms.DataGridView curatorsGrid;
        private System.Windows.Forms.Button add_student_btn;
        private System.Windows.Forms.TextBox student_id_tb;
        private System.Windows.Forms.TextBox student_name_tb;
        private System.Windows.Forms.TextBox student_age_tb;
        private System.Windows.Forms.TextBox student_groupId_tb;
        private System.Windows.Forms.Button add_group_btn;
        private System.Windows.Forms.Button add_curator_btn;
        private System.Windows.Forms.Button delete_student_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update_student;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button group_delete_btn;
        private System.Windows.Forms.TextBox group_name_tb;
        private System.Windows.Forms.TextBox group_id_tb;
        private System.Windows.Forms.Button update_curator_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button curator_delete_btn;
        private System.Windows.Forms.TextBox curator_groupId_tb;
        private System.Windows.Forms.TextBox curator_email_tb;
        private System.Windows.Forms.TextBox curator_name_tb;
        private System.Windows.Forms.TextBox curator_id_tb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox count_group_by_id_tb;
        private System.Windows.Forms.Button count_group_btn;
        private System.Windows.Forms.Label group_count_label;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox curator_by_student_tb;
        private System.Windows.Forms.Button curator_by_student_btn;
        private System.Windows.Forms.Label curator_by_student_label;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox avg_age_by_curator_tb;
        private System.Windows.Forms.Button avg_age_by_curator_btn;
        private System.Windows.Forms.Label avg_age_by_curator_label;
        private System.Windows.Forms.Button All_students;
        private System.Windows.Forms.Label group_count;
        private System.Windows.Forms.TextBox group_countt;
        private System.Windows.Forms.Button get_curator_name;
        private System.Windows.Forms.TextBox сurators_name;
        private System.Windows.Forms.Button get_average_age;
        private System.Windows.Forms.TextBox av_age;
    }
}

