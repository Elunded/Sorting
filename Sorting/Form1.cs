namespace Sorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            �����ToolStripMenuItem.Checked = false;
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            �����ToolStripMenuItem.Checked = false;
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertionSort insertionSort = new InsertionSort();
            insertionSort.Show();
            insertionSort.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}