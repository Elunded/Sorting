using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Sorting
{
    public partial class InsertionSort : Form
    {
        public InsertionSort()
        {
            InitializeComponent();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
                string[] textNumbers = textBox1.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int[] numbers = new int[textNumbers.Length];
                for (int i = 0; i < textNumbers.Length; i++)
                {
                    numbers[i] = int.Parse(textNumbers[i]);
                if (numbers[i] > 9)
                {
                    errorProvider1.SetError(textBox1, "Не вірні данні!");
                    return;
                }
                }
            if (numbers.Length == 0) return;

            if (this.Controls.Contains(pictures))
            {
                this.Controls.Remove(pictures);
            }
            this.pictures = new Panel();
            
            pictures.Width = this.Width - 50;
            pictures.Height = (pictures.Width - (40 * numbers.Length)) / numbers.Length;
            pictures.Location = new Point(textBox1.Location.X, textBox1.Location.Y + 100);
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            for (int i = 0; i < numbers.Length; i++)
            {
                pictureBoxes.Add(new PictureBox());
                pictureBoxes[i].Height = pictures.Height;
                pictureBoxes[i].Width = pictures.Height;
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                if (i > 0) pictureBoxes[i].Location = new Point(pictureBoxes[i-1].Location.X + pictureBoxes[i].Width + 40,
                    pictureBoxes[i - 1].Location.Y);
                switch (numbers[i])
                {
                    case 0:
                        pictureBoxes[i].Image = Image.FromFile("../nums/0.png");
                        break;
                    case 1:
                        pictureBoxes[i].Image = Image.FromFile("nums/1.png");
                        break;
                    case 2:
                        pictureBoxes[i].Image = Image.FromFile("nums/2.png");
                        break;
                    case 3:
                        pictureBoxes[i].Image = Image.FromFile("nums/3.png");
                        break;
                    case 4:
                        pictureBoxes[i].Image = Image.FromFile("nums/4.png");
                        break;
                    case 5:
                        pictureBoxes[i].Image = Image.FromFile("nums/5.png");
                        break;
                    case 6:
                        pictureBoxes[i].Image = Image.FromFile("nums/6.png");
                        break;
                    case 7:
                        pictureBoxes[i].Image = Image.FromFile("nums/7.png");
                        break;
                    case 8:
                        pictureBoxes[i].Image = Image.FromFile("nums/8.png");
                        break;
                    case 9:
                        pictureBoxes[i].Image = Image.FromFile("nums/9.png");
                        break;
                    default:
                        break;
                }
                pictures.Controls.Add(pictureBoxes[i]);
            }
            this.Controls.Add(pictures);

            int index, currentNumber;
            for (int i = 0; i < numbers.Length; i++)
            {
                index = i;
                currentNumber = numbers[i];
                while (index > 0 && currentNumber < numbers[index - 1])
                {
                    numbers[index] = numbers[index - 1];
                    index--;
                }
                numbers[index] = currentNumber;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
        private void InsertionClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }

        private void вГоловнеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити програму?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {    
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
