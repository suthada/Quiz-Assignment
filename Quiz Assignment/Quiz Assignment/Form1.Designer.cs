namespace Quiz_Assignment
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExpenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxList = new System.Windows.Forms.TextBox();
            this.textBoxIncome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExpenses = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1Add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnList,
            this.ColumnIncome,
            this.ColumnExpenses});
            this.dataGridView1.Location = new System.Drawing.Point(429, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(424, 383);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColumnList
            // 
            this.ColumnList.HeaderText = "List";
            this.ColumnList.MinimumWidth = 6;
            this.ColumnList.Name = "ColumnList";
            this.ColumnList.Width = 125;
            // 
            // ColumnIncome
            // 
            this.ColumnIncome.HeaderText = "Income";
            this.ColumnIncome.MinimumWidth = 6;
            this.ColumnIncome.Name = "ColumnIncome";
            this.ColumnIncome.Width = 125;
            // 
            // ColumnExpenses
            // 
            this.ColumnExpenses.HeaderText = "Expenses";
            this.ColumnExpenses.MinimumWidth = 6;
            this.ColumnExpenses.Name = "ColumnExpenses";
            this.ColumnExpenses.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "List";
            // 
            // textBoxList
            // 
            this.textBoxList.Location = new System.Drawing.Point(110, 52);
            this.textBoxList.Name = "textBoxList";
            this.textBoxList.Size = new System.Drawing.Size(125, 27);
            this.textBoxList.TabIndex = 4;
            // 
            // textBoxIncome
            // 
            this.textBoxIncome.Location = new System.Drawing.Point(110, 110);
            this.textBoxIncome.Name = "textBoxIncome";
            this.textBoxIncome.Size = new System.Drawing.Size(125, 27);
            this.textBoxIncome.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Income";
            // 
            // textBoxExpenses
            // 
            this.textBoxExpenses.Location = new System.Drawing.Point(110, 174);
            this.textBoxExpenses.Name = "textBoxExpenses";
            this.textBoxExpenses.Size = new System.Drawing.Size(125, 27);
            this.textBoxExpenses.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Expenses";
            // 
            // button1Add
            // 
            this.button1Add.Location = new System.Drawing.Point(269, 102);
            this.button1Add.Name = "button1Add";
            this.button1Add.Size = new System.Drawing.Size(116, 43);
            this.button1Add.TabIndex = 9;
            this.button1Add.Text = "Add";
            this.button1Add.UseVisualStyleBackColor = true;
            this.button1Add.Click += new System.EventHandler(this.button1Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(35, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 168);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AllData";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Expenses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Income";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1Add);
            this.Controls.Add(this.textBoxExpenses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private TextBox textBoxList;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnIncome;
        private DataGridViewTextBoxColumn ColumnExpenses;
        private DataGridViewTextBoxColumn ColumnList;
        private Label label1;
        private TextBox textBoxIncome;
        private Label label2;
        private TextBox textBoxExpenses;
        private Label label3;
        private Button button1Add;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
    }
}