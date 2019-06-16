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
            teacherMetroGrid.Hide();
            
        }
        int selectedRow;
        DataTable table = new DataTable();



        private void TeacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_info);

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.teacherTableAdapter.Fill(this.student_info.Teacher);
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            
           


            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                int idnew = Int32.Parse(idTextBox.Text);              
                try {
                    int n;
                    bool isNumeric = true;
                    isNumeric = int.TryParse(last_NameTextBox.Text, out n);
                    if (isNumeric == true)
                    {
                        throw new FormatException();                       
                    }
                    this.teacherTableAdapter.Insert(idnew, nameTextBox.Text, last_NameTextBox.Text,true);
                    //table.Rows.Add(idnew, nameTextBox.Text, last_NameTextBox.Text);
                    this.teacherTableAdapter.Fill(this.student_info.Teacher);


                }
                catch (FormatException ex2)
                {
                    MessageBox.Show("Name can`t be a number");

                }
                
            }
            catch(FormatException ex)
            {
                MessageBox.Show("The new ID should be a number");
            }
            idTextBox.Text = "";
            nameTextBox.Text = "";
            last_NameTextBox.Text = "";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel4.Height = button1.Height;
            //panel4.Top = button1.Top;

            //panel4.Location = new Point(318, 187);
            timer1.Start();
            Move2 = true;
            teacherMetroGrid.Hide();




        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panel4.Height = button2.Height;
            //change panel 4 postion to the same as button
            //panel4.Location = new Point(318,360);
            timer1.Start();
            Move1 = true;
            teacherMetroGrid.Show();
            

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
            selectedRow = e.RowIndex;
            DataGridViewRow row = teacherMetroGrid.Rows[selectedRow];
            idTextBox.Text = row.Cells[0].Value.ToString();
            nameTextBox.Text = row.Cells[1].Value.ToString();
            last_NameTextBox.Text = row.Cells[2].Value.ToString();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {            
            DataView table = new DataView(student_info.Teacher);
            table.RowFilter = string.Format("Name LIKE '%{0}%'", textBox1.Text);
            teacherMetroGrid.DataSource = table;
            
            
        }


        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            //  void DisplayImage()
            //  {
            //      PictureBox pictureBox1 = new PictureBox();
            //      pictureBox1.Location = new Point(899, 60);
            //      this.Controls.Add(pictureBox1);
            //      pictureBox1.Load(@"C:\Users\Sina\source\repos\Student_management\attach\x.gif");
            //  }
        }
       // private void AnimImage()
       // {
       //     pictureBox1.Enabled = true;
       //     pictureBox1.Visible = true;
       //     System.Threading.Thread.Sleep(5000);
       //     //system.... is to put delay when application starts
       //     pictureBox1.Visible = false;
       //     pictureBox1.Enabled = false;
       // }
    }
}
