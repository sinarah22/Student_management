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
            timer1.Start();
            Move2 = true;
          

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panel4.Height = button2.Height;
            //change panel 4 postion to the same as button
            //panel4.Location = new Point(318,360);
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            sea
            DataView dv = new DataView(student_info.Teacher);
            dv.RowFilter = string.Format("Name LIKE '%{0}%'", textBox1.Text);
            teacherMetroGrid.DataSource = dv;
        }
    }
}
