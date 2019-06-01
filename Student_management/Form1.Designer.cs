namespace Student_management
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label gradeLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label idLabel;
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.miniToolStrip = new System.Windows.Forms.BindingNavigator(this.components);
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.Add = new MetroFramework.Controls.MetroButton();
            this.Student_table = new System.Windows.Forms.DataGridView();
            this.teacherDataGridView = new System.Windows.Forms.DataGridView();
            this.Search_TB = new System.Windows.Forms.TextBox();
            this.Search_button = new MetroFramework.Controls.MetroButton();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_info = new Student_management.student_info();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custom_Button2 = new Student_management.Custom_Button();
            this.tableTableAdapter = new Student_management.student_infoTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Student_management.student_infoTableAdapters.TableAdapterManager();
            this.teacherTableAdapter = new Student_management.student_infoTableAdapters.TeacherTableAdapter();
            this.teacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            gradeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gradeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            gradeLabel.Location = new System.Drawing.Point(1115, 343);
            gradeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(75, 23);
            gradeLabel.TabIndex = 12;
            gradeLabel.Text = "Grade:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            nameLabel.Location = new System.Drawing.Point(1115, 266);
            nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(72, 23);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            last_NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            last_NameLabel.Location = new System.Drawing.Point(1115, 305);
            last_NameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(112, 23);
            last_NameLabel.TabIndex = 12;
            last_NameLabel.Text = "Last Name:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            idLabel.Location = new System.Drawing.Point(1115, 227);
            idLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(33, 23);
            idLabel.TabIndex = 12;
            idLabel.Text = "ID:";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 644);
            this.panel1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Student_management.Properties.Resources.teacher;
            this.button2.Location = new System.Drawing.Point(13, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 121);
            this.button2.TabIndex = 16;
            this.button2.Text = "Teachers";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Student_management.Properties.Resources.student2;
            this.button1.Location = new System.Drawing.Point(13, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 121);
            this.button1.TabIndex = 15;
            this.button1.Text = "Students";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(312, 614);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 90);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 106);
            this.panel3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(59, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 73);
            this.label1.TabIndex = 14;
            this.label1.Text = "School ";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(318, 187);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 121);
            this.panel4.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(1229, 301);
            this.last_NameTextBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(156, 30);
            this.last_NameTextBox.TabIndex = 12;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(1229, 262);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(156, 30);
            this.nameTextBox.TabIndex = 12;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AddNewItem = null;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.CountItem = null;
            this.miniToolStrip.DeleteItem = null;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.MoveFirstItem = null;
            this.miniToolStrip.MoveLastItem = null;
            this.miniToolStrip.MoveNextItem = null;
            this.miniToolStrip.MovePreviousItem = null;
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.PositionItem = null;
            this.miniToolStrip.Size = new System.Drawing.Size(336, 27);
            this.miniToolStrip.TabIndex = 0;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.gradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Grade", true));
            this.gradeTextBox.Location = new System.Drawing.Point(1229, 339);
            this.gradeTextBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(156, 30);
            this.gradeTextBox.TabIndex = 12;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(1229, 224);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(156, 30);
            this.idTextBox.TabIndex = 13;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(1229, 389);
            this.Add.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(156, 45);
            this.Add.TabIndex = 12;
            this.Add.Text = "add new";
            this.Add.UseSelectable = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Student_table
            // 
            this.Student_table.AutoGenerateColumns = false;
            this.Student_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.Student_table.DataSource = this.tableBindingSource;
            this.Student_table.Location = new System.Drawing.Point(350, 90);
            this.Student_table.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Student_table.Name = "Student_table";
            this.Student_table.RowHeadersWidth = 51;
            this.Student_table.RowTemplate.Height = 24;
            this.Student_table.Size = new System.Drawing.Size(559, 318);
            this.Student_table.TabIndex = 3;
            // 
            // teacherDataGridView
            // 
            this.teacherDataGridView.AutoGenerateColumns = false;
            this.teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.teacherDataGridView.DataSource = this.teacherBindingSource;
            this.teacherDataGridView.Location = new System.Drawing.Point(350, 90);
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.RowHeadersWidth = 51;
            this.teacherDataGridView.RowTemplate.Height = 24;
            this.teacherDataGridView.Size = new System.Drawing.Size(559, 302);
            this.teacherDataGridView.TabIndex = 3;
            this.teacherDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherDataGridView_CellContentClick);
            // 
            // Search_TB
            // 
            this.Search_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.Search_TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Grade", true));
            this.Search_TB.Location = new System.Drawing.Point(341, 421);
            this.Search_TB.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Search_TB.Name = "Search_TB";
            this.Search_TB.Size = new System.Drawing.Size(156, 30);
            this.Search_TB.TabIndex = 18;
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(507, 421);
            this.Search_button.Margin = new System.Windows.Forms.Padding(0);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(100, 29);
            this.Search_button.TabIndex = 19;
            this.Search_button.Text = "Search:";
            this.Search_button.UseSelectable = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.student_info;
            // 
            // student_info
            // 
            this.student_info.DataSetName = "student_info";
            this.student_info.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Gender";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Gender";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.student_info;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last_Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Grade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // custom_Button2
            // 
            this.custom_Button2.Angle = 62F;
            this.custom_Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.custom_Button2.BorderRadius = 1;
            this.custom_Button2.Color0 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.custom_Button2.Color1 = System.Drawing.Color.Olive;
            this.custom_Button2.Location = new System.Drawing.Point(1229, 21);
            this.custom_Button2.Name = "custom_Button2";
            this.custom_Button2.Size = new System.Drawing.Size(142, 153);
            this.custom_Button2.TabIndex = 3;
            this.custom_Button2.Click += new System.EventHandler(this.Custom_Button2_Click);
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Student_management.student_infoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // teacherBindingSource1
            // 
            this.teacherBindingSource1.DataMember = "Teacher";
            this.teacherBindingSource1.DataSource = this.student_info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 704);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Search_TB);
            this.Controls.Add(this.teacherDataGridView);
            this.Controls.Add(this.Student_table);
            this.Controls.Add(this.custom_Button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Add);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(gradeLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.gradeTextBox);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Form1";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.DeepSkyBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private student_info student_info;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private student_infoTableAdapters.TableTableAdapter tableTableAdapter;
        private student_infoTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private student_infoTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView Student_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private MetroFramework.Controls.MetroButton Add;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.BindingNavigator miniToolStrip;
        private System.Windows.Forms.DataGridView teacherDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Custom_Button custom_Button2;
        private System.Windows.Forms.TextBox Search_TB;
        private MetroFramework.Controls.MetroButton Search_button;
        private System.Windows.Forms.BindingSource teacherBindingSource1;
    }
}

