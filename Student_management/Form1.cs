using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Student_management
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Point PW;
        bool Move1;
        bool Move2;
        bool flag;
        public Form1()
        {
            InitializeComponent();
            PW = panel4.Location;
            Move1 = false;
            Move2 = false;
            teacherDataGridView.Hide();
            Student_table.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_info.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.student_info.Teacher);
            // TODO: This line of code loads data into the 'student_info.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.student_info.Table);
            

        }

        private void TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_info);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.AddNew();
           //while(flag=false) {
           //    if (Error_Label.Text == "")
           //    {
           //        idTextBox.Text = "can not save";
           //    }
           //    else
           //    {
           //        Error_Label.Text = "added saucdesfully";
           //        flag = true;
           //    }
           //}
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel4.Height = button1.Height;
            //panel4.Top = button1.Top;

            //panel4.Location = new Point(318, 187);

            teacherDataGridView.Hide();
            Student_table.Show();
            timer1.Start();
            Move2 = true;
            
            
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panel4.Height = button2.Height;
            //change panel 4 postion to the same as button
            //panel4.Location = new Point(318,360);
            teacherDataGridView.Show();
            Student_table.Hide();

            timer1.Start();
            Move1 = true;
            


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Custom_Button1_Click(object sender, EventArgs e)
        {

        }

        private void Custom_Button2_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Move1)
            {               
                panel4.Top += 30;

                    if (panel4.Top >= 340)
                    {
                        timer1.Stop();
                        Move1 = false;
                        this.Refresh();
                    //panel4.Top -= 30;

                }
                

            }
            if (Move2)
            {
                
                panel4.Top -= 30;
                
                if (panel4.Top <= 190)
                {
                    timer1.Stop();
                    Move2 = false;
                    this.Refresh();
                    //panel4.Top += 30;
                }
                
            }
        }

        private void TeacherDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.teacherTableAdapter.SearchByName2(this.student_info.Teacher, Search_TB.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void SearchByName2ToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void SearchByName2ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
