namespace FractalTree
{
    partial class MyForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LeftSideNum = new System.Windows.Forms.NumericUpDown();
            this.RightSideNum = new System.Windows.Forms.NumericUpDown();
            this.LengthNum = new System.Windows.Forms.NumericUpDown();
            this.LevelNum = new System.Windows.Forms.NumericUpDown();
            this.myGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BNum = new System.Windows.Forms.NumericUpDown();
            this.RNum = new System.Windows.Forms.NumericUpDown();
            this.GNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftSideNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightSideNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelNum)).BeginInit();
            this.myGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNum)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 525);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LeftSideNum
            // 
            this.LeftSideNum.Location = new System.Drawing.Point(45, 65);
            this.LeftSideNum.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.LeftSideNum.Name = "LeftSideNum";
            this.LeftSideNum.Size = new System.Drawing.Size(50, 20);
            this.LeftSideNum.TabIndex = 1;
            this.LeftSideNum.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.LeftSideNum.ValueChanged += new System.EventHandler(this.LeftSideNum_ValueChanged);
            // 
            // RightSideNum
            // 
            this.RightSideNum.Location = new System.Drawing.Point(45, 130);
            this.RightSideNum.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.RightSideNum.Name = "RightSideNum";
            this.RightSideNum.Size = new System.Drawing.Size(50, 20);
            this.RightSideNum.TabIndex = 2;
            this.RightSideNum.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.RightSideNum.ValueChanged += new System.EventHandler(this.RightSideNum_ValueChanged);
            // 
            // LengthNum
            // 
            this.LengthNum.Location = new System.Drawing.Point(45, 210);
            this.LengthNum.Maximum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.LengthNum.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.LengthNum.Name = "LengthNum";
            this.LengthNum.Size = new System.Drawing.Size(50, 20);
            this.LengthNum.TabIndex = 3;
            this.LengthNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.LengthNum.ValueChanged += new System.EventHandler(this.LegnthNum_ValueChanged);
            // 
            // LevelNum
            // 
            this.LevelNum.Location = new System.Drawing.Point(45, 290);
            this.LevelNum.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.LevelNum.Name = "LevelNum";
            this.LevelNum.Size = new System.Drawing.Size(50, 20);
            this.LevelNum.TabIndex = 4;
            this.LevelNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LevelNum.ValueChanged += new System.EventHandler(this.LevelNum_ValueChanged);
            // 
            // myGroupBox
            // 
            this.myGroupBox.Controls.Add(this.label8);
            this.myGroupBox.Controls.Add(this.label7);
            this.myGroupBox.Controls.Add(this.label6);
            this.myGroupBox.Controls.Add(this.label5);
            this.myGroupBox.Controls.Add(this.BNum);
            this.myGroupBox.Controls.Add(this.RNum);
            this.myGroupBox.Controls.Add(this.GNum);
            this.myGroupBox.Controls.Add(this.label4);
            this.myGroupBox.Controls.Add(this.label3);
            this.myGroupBox.Controls.Add(this.label2);
            this.myGroupBox.Controls.Add(this.label1);
            this.myGroupBox.Controls.Add(this.LeftSideNum);
            this.myGroupBox.Controls.Add(this.RightSideNum);
            this.myGroupBox.Controls.Add(this.LevelNum);
            this.myGroupBox.Controls.Add(this.LengthNum);
            this.myGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.myGroupBox.Location = new System.Drawing.Point(634, 24);
            this.myGroupBox.Name = "myGroupBox";
            this.myGroupBox.Size = new System.Drawing.Size(150, 537);
            this.myGroupBox.TabIndex = 5;
            this.myGroupBox.TabStop = false;
            this.myGroupBox.Text = "Users Control";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tree\'s color";
            // 
            // BNum
            // 
            this.BNum.Location = new System.Drawing.Point(42, 473);
            this.BNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BNum.Name = "BNum";
            this.BNum.Size = new System.Drawing.Size(50, 20);
            this.BNum.TabIndex = 13;
            this.BNum.ValueChanged += new System.EventHandler(this.BNum_ValueChanged);
            // 
            // RNum
            // 
            this.RNum.Location = new System.Drawing.Point(42, 394);
            this.RNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RNum.Name = "RNum";
            this.RNum.Size = new System.Drawing.Size(50, 20);
            this.RNum.TabIndex = 12;
            this.RNum.ValueChanged += new System.EventHandler(this.RNum_ValueChanged);
            // 
            // GNum
            // 
            this.GNum.Location = new System.Drawing.Point(42, 433);
            this.GNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GNum.Name = "GNum";
            this.GNum.Size = new System.Drawing.Size(50, 20);
            this.GNum.TabIndex = 11;
            this.GNum.ValueChanged += new System.EventHandler(this.GNum_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Level\'s number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Size of tree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Angle of left branches";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Angle of right branches";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.myGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyForm";
            this.Text = "FractalTree";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.Resize += new System.EventHandler(this.MyForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftSideNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightSideNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelNum)).EndInit();
            this.myGroupBox.ResumeLayout(false);
            this.myGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNum)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown LeftSideNum;
        private System.Windows.Forms.NumericUpDown RightSideNum;
        private System.Windows.Forms.NumericUpDown LengthNum;
        private System.Windows.Forms.NumericUpDown LevelNum;
        private System.Windows.Forms.GroupBox myGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown BNum;
        private System.Windows.Forms.NumericUpDown RNum;
        private System.Windows.Forms.NumericUpDown GNum;
    }
}

