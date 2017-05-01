using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalTree
{
    public partial class MyForm : Form
    {

        Tree mFractalTree;
        Bitmap mBitmap;
        Color mColor;

        public MyForm()
        {
            InitializeComponent();
            mBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            mColor = Color.FromArgb((int)RNum.Value, (int)GNum.Value, (int)BNum.Value);
            mFractalTree = new Tree((int)LeftSideNum.Value, (int)RightSideNum.Value, (int)LengthNum.Value, (int)LevelNum.Value, mBitmap, mColor); 
        }

        private void MyPaint()
        {
            pictureBox1.Image = mBitmap;
            pictureBox1.Invalidate();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            mFractalTree.OnPictureBoxDraw += MyPaint;            
            mFractalTree.InitTree();
        }

        private void MyForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                return;
            pictureBox1.Width = this.Width - myGroupBox.Width - 10;
            pictureBox1.Height = this.Height - 5;
            mFractalTree.UpdateStartCoord(pictureBox1.Width / 2, pictureBox1.Height - 150);
            int maxLenght = 125;
            if (this.WindowState == FormWindowState.Maximized)
                maxLenght = 175;
            LengthNum.Maximum = maxLenght;
            mBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            mFractalTree.UpdateLenght((int)LengthNum.Value, mBitmap);
        }

        private void LeftSideNum_ValueChanged(object sender, EventArgs e)
        {
            mBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            mFractalTree.UpdateLeftSide((int)LeftSideNum.Value, mBitmap);
        }

        private void RightSideNum_ValueChanged(object sender, EventArgs e)
        {
            mBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            mFractalTree.UpdateRightSide((int)RightSideNum.Value, mBitmap);
        }

        private void LegnthNum_ValueChanged(object sender, EventArgs e)
        {
            mBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            mFractalTree.UpdateLenght((int)LengthNum.Value, mBitmap);
        }

        private void LevelNum_ValueChanged(object sender, EventArgs e)
        {
            mBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            mFractalTree.UpdateLevel((int)LevelNum.Value, mBitmap);
        }

        private void RNum_ValueChanged(object sender, EventArgs e)
        {
            mColor = Color.FromArgb((int)RNum.Value, (int)GNum.Value, (int)BNum.Value);
            mBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            mFractalTree.UpdateColor(mColor, mBitmap);
        }

        private void GNum_ValueChanged(object sender, EventArgs e)
        {
            mColor = Color.FromArgb((int)RNum.Value, (int)GNum.Value, (int)BNum.Value);
            mBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            mFractalTree.UpdateColor(mColor, mBitmap);
        }

        private void BNum_ValueChanged(object sender, EventArgs e)
        {
            mColor = Color.FromArgb((int)RNum.Value, (int)GNum.Value, (int)BNum.Value);
            mBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            mFractalTree.UpdateColor(mColor, mBitmap);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm myAboutForm = new AboutForm();
            myAboutForm.ShowDialog();
        }
    }
}
