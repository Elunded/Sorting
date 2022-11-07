using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class NumberBox
    {
        PictureBox pictureBox;

        public NumberBox(int i)
        {
            pictureBox = new PictureBox();
            switch (i)
            {
                case 0:
                    pictureBox.Image = Image.FromFile("D:/nums/0.png");
                    break;
                case 1:
                    pictureBox.Image = Image.FromFile("D:/nums/1.png");
                    break;
                case 2:
                    pictureBox.Image = Image.FromFile("D:/nums/2.png");
                    break;
                case 3:
                    pictureBox.Image = Image.FromFile("D:/nums/3.png");
                    break;
                case 4:
                    pictureBox.Image = Image.FromFile("D:/nums/4.png");
                    break;
                case 5:
                    pictureBox.Image = Image.FromFile("D:/nums/5.png");
                    break;
                case 6:
                    pictureBox.Image = Image.FromFile("D:/nums/6.png");
                    break;
                case 7:
                    pictureBox.Image = Image.FromFile("D:/nums/7.png");
                    break;
                case 8:
                    pictureBox.Image = Image.FromFile("D:/nums/8.png");
                    break;
                case 9:
                    pictureBox.Image = Image.FromFile("D:/nums/9.png");
                    break;
                default:
                    break;
            }
        }
    }
}
