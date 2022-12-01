namespace LabN7V3
{
    public partial class Form1 : Form
    {


        private int width = 150;
        private int height = 150;
        private Color colour = Color.Orange;
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void bigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = 300;
            height = 300;
            Invalidate();
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = 150;
            height = 150;
            Invalidate();
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colour = Color.Orange;
            Invalidate();
        }

        private void magentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colour = Color.Magenta;
            Invalidate();
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colour = Color.Cyan;
            Invalidate();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colour = Color.Green;
            Invalidate();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colour = Color.Black;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Pen pen = new Pen(colour, 15);
            graphic.DrawRectangle(pen, new Rectangle(150, 150, width, height));
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);

            if (e.Button == MouseButtons.Right) 
                contextMenuStrip1.Show(this, point);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool isControlPressed = e.Control;
            bool isShiftPressed = e.Shift;



            if (isControlPressed && e.KeyCode == Keys.S)
            {
                width = 150;
                height = 150;
                Invalidate();
            }
            if (isControlPressed && e.KeyCode == Keys.B)
            {
                width = 300;
                height = 300;
                Invalidate();
            }
            if (isShiftPressed && e.KeyCode == Keys.O)
            {
                colour = Color.Orange;
                Invalidate();
            }
            if (isShiftPressed && e.KeyCode == Keys.M)
            {
                colour = Color.Magenta;
                Invalidate();
            }
            if (isShiftPressed && e.KeyCode == Keys.C)
            {
                colour = Color.Cyan;
                Invalidate();
            }
            if (isShiftPressed && e.KeyCode == Keys.G)
            {
                colour = Color.Green;
                Invalidate();
            }
            if (isShiftPressed && e.KeyCode == Keys.B)
            {
                colour = Color.Black;
                Invalidate();
            }

            


        }

    }
}