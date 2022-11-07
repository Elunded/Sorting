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

        private void òåìíàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ñâ³òëàToolStripMenuItem.Checked = false;
        }

        private void ñâ³òëàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            òåìíàToolStripMenuItem.Checked = false;
        }

        private void ïðîÏðîãðàìóToolStripMenuItem_Click(object sender, EventArgs e)
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