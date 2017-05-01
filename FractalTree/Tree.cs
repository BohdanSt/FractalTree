using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FractalTree
{
    class Tree
    {
        const double mPI = 3.14159265;
        const double mEPS = 0.0000001;
        
        double mLsideRad;
        double mRsideRad;
        double mLength;
        int mLevel;
        
        Bitmap mBitmap;
        Point mBegin, mEnd;
        Pen mBlackPen, mUsersPen;
        Graphics mGraphics;

        double mMinLenght;
        int mStartX;
        int mStartY;

        public delegate void PictureBoxDraw ( );
        public event PictureBoxDraw OnPictureBoxDraw = delegate( ) { };

        public Tree(int lside, int rside, int length, int level, Bitmap bitmap, Color color) 
        {
            mStartX = 300;
            mStartY = 450;
            mLsideRad = mPI * lside / 180;
            mRsideRad = mPI * rside / 180;
            mLength = length;
            mLevel = level;
            mBitmap = bitmap;
            mUsersPen = new Pen(color, 1);
        }

        public void InitTree()
        {
            UpdateMinLenght();
            mBlackPen = new Pen(Color.Black, 1);
            mGraphics = Graphics.FromImage(mBitmap);
            BuildTree(mStartX, mStartY, mLength, mPI / 2);
            OnPictureBoxDraw();
        } 

        private void BuildTree(double posx, double posy, double lenght, double rad)
        {
            if (lenght >= mMinLenght)
            {
                mBegin = new Point((int)(posx + mEPS), (int)(posy + mEPS));

                posx = posx + lenght * Math.Cos(rad);
                posy = posy - lenght * Math.Sin(rad);

                mEnd = new Point((int)(posx + mEPS), (int)(posy + mEPS));

                if (lenght > 5)
                    mGraphics.DrawLine(mBlackPen, mBegin, mEnd);
                else
                    mGraphics.DrawLine(mUsersPen, mBegin, mEnd);

                lenght = lenght * 0.7;

                BuildTree(posx, posy, lenght, rad + mLsideRad);
                BuildTree(posx, posy, lenght, rad - mRsideRad);
            }
        }

        private void UpdateMinLenght()
        { 
            mMinLenght = mLength;
            for (int i = 0; i < mLevel; i++)
            { 
                mMinLenght = mMinLenght * 0.7;
            }
        }

        public void UpdateStartCoord(int x, int y)
        {
            mStartX = x;
            mStartY = y;
        }

        public void UpdateLeftSide(int lside, Bitmap bitmap)
        {
            mLsideRad = mPI * lside / 180;
            mBitmap = bitmap;
            mGraphics = Graphics.FromImage(mBitmap);
            BuildTree(mStartX, mStartY, mLength, mPI / 2);
            OnPictureBoxDraw();
        }

        public void UpdateRightSide(int rside, Bitmap bitmap)
        {
            mRsideRad = mPI * rside / 180;
            mBitmap = bitmap;
            mGraphics = Graphics.FromImage(mBitmap);
            BuildTree(mStartX, mStartY, mLength, mPI / 2);
            OnPictureBoxDraw();
        }

        public void UpdateLenght(int lenght, Bitmap bitmap)
        {
            mLength = lenght;
            mBitmap = bitmap;
            mGraphics = Graphics.FromImage(mBitmap);
            BuildTree(mStartX, mStartY, mLength, mPI / 2);
            OnPictureBoxDraw();
        }

        public void UpdateLevel(int level, Bitmap bitmap)
        {
            mLevel = level;
            UpdateMinLenght();
            mBitmap = bitmap;
            mGraphics = Graphics.FromImage(mBitmap);
            BuildTree(mStartX, mStartY, mLength, mPI / 2);
            OnPictureBoxDraw();
        }

        public void UpdateColor(Color color, Bitmap bitmap)
        {
            mUsersPen = new Pen(color, 1);
            mBitmap = bitmap;
            mGraphics = Graphics.FromImage(mBitmap);
            BuildTree(mStartX, mStartY, mLength, mPI / 2);
            OnPictureBoxDraw();
        }
    }
}
