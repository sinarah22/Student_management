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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.teacherMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_info = new Student_management.student_info();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Student_management.student_infoTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Student_management.student_infoTableAdapters.TableAdapterManager();
            this.teacherTableAdapter = new Student_management.student_infoTableAdapters.TeacherTableAdapter();
            this.teacherBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.teacherBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            gradeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gradeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            gradeLabel.Location = new System.Drawing.Point(887, 390);
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
            nameLabel.Location = new System.Drawing.Point(887, 313);
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
            last_NameLabel.Location = new System.Drawing.Point(887, 352);
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
            idLabel.Location = new System.Drawing.Point(887, 274);
            idLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(33, 23);
            idLabel.TabIndex = 12;
            idLabel.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            label2.Location = new System.Drawing.Point(887, 132);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 23);
            label2.TabIndex = 22;
            label2.Text = "Search :";
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
            this.panel1.Size = new System.Drawing.Size(312, 530);
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
            this.panel2.Location = new System.Drawing.Point(312, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 90);
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
            this.last_NameTextBox.Location = new System.Drawing.Point(1001, 348);
            this.last_NameTextBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(156, 30);
            this.last_NameTextBox.TabIndex = 12;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(1001, 309);
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
            this.gradeTextBox.Location = new System.Drawing.Point(1001, 386);
            this.gradeTextBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(156, 30);
            this.gradeTextBox.TabIndex = 12;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(1001, 271);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(156, 30);
            this.idTextBox.TabIndex = 13;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(1001, 436);
            this.Add.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(156, 45);
            this.Add.TabIndex = 12;
            this.Add.Text = "add new";
            this.Add.UseSelectable = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1001, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 30);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // teacherMetroGrid
            // 
            this.teacherMetroGrid.AllowUserToResizeRows = false;
            this.teacherMetroGrid.AutoGenerateColumns = false;
            this.teacherMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.teacherMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teacherMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.teacherMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacherMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.teacherMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.teacherMetroGrid.DataSource = this.teacherBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.teacherMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.teacherMetroGrid.EnableHeadersVisualStyles = false;
            this.teacherMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.teacherMetroGrid.GridColor = System.Drawing.Color.Gray;
            this.teacherMetroGrid.Location = new System.Drawing.Point(351, 111);
            this.teacherMetroGrid.Name = "teacherMetroGrid";
            this.teacherMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacherMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.teacherMetroGrid.RowHeadersWidth = 51;
            this.teacherMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.teacherMetroGrid.RowTemplate.Height = 24;
            this.teacherMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teacherMetroGrid.Size = new System.Drawing.Size(522, 370);
            this.teacherMetroGrid.TabIndex = 19;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Gender";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Gender";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // teacherBindingSource1
            // 
            this.teacherBindingSource1.DataMember = "Teacher";
            this.teacherBindingSource1.DataSource = this.student_info;
            // 
            // student_info
            // 
            this.student_info.DataSetName = "student_info";
            this.student_info.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.student_info;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.student_info;
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
            // teacherBindingSource2
            // 
            this.teacherBindingSource2.DataMember = "Teacher";
            this.teacherBindingSource2.DataSource = this.student_info;
            // 
            // teacherBindingSource3
            // 
            this.teacherBindingSource3.DataMember = "Teacher";
            this.teacherBindingSource3.DataSource = this.student_info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 590);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.teacherMetroGrid);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.teacherMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource3)).EndInit();
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
        private MetroFramework.Controls.MetroButton Add;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.BindingNavigator miniToolStrip;
        private System.Windows.Forms.BindingSource teacherBindingSource1;
        private System.Windows.Forms.BindingSource teacherBindingSource2;
        private System.Windows.Forms.BindingSource teacherBindingSource3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroGrid teacherMetroGrid;
    }
}

