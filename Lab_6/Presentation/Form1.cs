using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using System.Text.RegularExpressions;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private readonly UniversityFacade facade;
        public Form1()
        {
            InitializeComponent();

            facade = new UniversityFacade();

            RefreshTables();
        }

        private void add_student_btn_Click(object sender, EventArgs e)
        {
            try
            {
                facade.AddStudent(
                    student_name_tb.Text,
                    int.Parse(student_age_tb.Text),
                    int.Parse(student_groupId_tb.Text)
                );

                RefreshTables();

                student_name_tb.Text = "";
                student_age_tb.Text = "";
                student_groupId_tb.Text = "";
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void delete_student_btn_Click(object sender, EventArgs e)
        {
            try
            {
                facade.DeleteStudent(int.Parse(student_id_tb.Text));
                RefreshTables();

                student_id_tb.Text = "";
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error");
        }

        private void RefreshTables()
        {
            groupsGrid.DataSource = facade.GetAllGroups();
            studentsGrid.DataSource = facade.GetAllStudents();
            curatorsGrid.DataSource = facade.GetAllCurators();
        }

        private void add_group_btn_Click(object sender, EventArgs e)
        {
            try
            {
                facade.AddGroup(
                    group_name_tb.Text
                );

                RefreshTables();

                group_name_tb.Text = "";
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void add_curator_btn_Click(object sender, EventArgs e)
        {
            try
            {

                string regularEmail = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";


                if (Regex.IsMatch(curator_email_tb.Text, regularEmail))
                {
                    facade.AddCurator(
                    curator_name_tb.Text,
                    curator_email_tb.Text,
                    int.Parse(curator_groupId_tb.Text)
                );

                    RefreshTables();

                    curator_name_tb.Text = "";
                    curator_email_tb.Text = "";
                    curator_groupId_tb.Text = "";
                }

                else
                {
                    ShowError("Пожалуйста, я делаю эту лабу очень уставшей, введи .... нормально почту!");
                }
                    

            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void count_group_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int groupId = int.Parse(count_group_by_id_tb.Text);
                group_count_label.Text = facade.CountStudentsInGroup(groupId).ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void curator_by_student_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = int.Parse(curator_by_student_tb.Text);
                curator_by_student_label.Text = facade.GetCuratourName(studentId).ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void avg_age_by_curator_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int curatorId = int.Parse(avg_age_by_curator_tb.Text);
                avg_age_by_curator_label.Text = facade.GetAverageAge(curatorId).ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void update_group_btn(object sender, EventArgs e)
        {
            try
            {
                facade.UpdateGroup(
                    int.Parse(group_id_tb.Text),
                    group_name_tb.Text
                    );

                RefreshTables();

                group_name_tb.Text = "";
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void update_student_Click(object sender, EventArgs e)
        {
            try
            {
                facade.UpdateStudent(
                    int.Parse(student_id_tb.Text),
                    student_name_tb.Text,
                    int.Parse(student_age_tb.Text),
                    int.Parse(student_groupId_tb.Text)
                    );

                RefreshTables();

                student_name_tb.Text = "";
                student_age_tb.Text = "";
                student_groupId_tb.Text = "";
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void update_curator_btn_Click(object sender, EventArgs e)
        {
            try
            {
                facade.UpdateCurator(
                    int.Parse(curator_id_tb.Text),
                    curator_name_tb.Text,
                    curator_email_tb.Text,
                    int.Parse(curator_groupId_tb.Text)
                    );

                RefreshTables();

                curator_name_tb.Text = "";
                curator_email_tb.Text = "";
                curator_groupId_tb.Text = "";
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void group_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                facade.DeleteGroup(int.Parse(group_id_tb.Text));
                RefreshTables();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void curator_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                facade.DeleteCurator(int.Parse(curator_id_tb.Text));
                RefreshTables();
            }
            catch (Exception ex) 
            {
                ShowError(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void All_students_Click(object sender, EventArgs e)
        {

            try
            {
                int groupId = int.Parse(group_id_tb.Text);
                if (groupId < 1)
                {
                    MessageBox.Show("Don't do this to me, please");
                } else
                    group_countt.Text = facade.CountStudentsInGroup(groupId).ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void get_curator_name_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = int.Parse(student_id_tb.Text);
                сurators_name.Text = facade.GetCuratourName(studentId).ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

        }

        private void get_average_age_Click(object sender, EventArgs e)
        {
            try
            {
                int curatorId = int.Parse(curator_groupId_tb.Text);
                av_age.Text = (Math.Round(facade.GetAverageAge(curatorId), 3)).ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}
