namespace recur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MyDraw(Graphics g, int N, int x, int y, int k, int j)
        {
            if (N == 0)
            {
                return;
            }
            else
            {
                g.DrawEllipse(new Pen(Brushes.Blue, 2), k, j, x, y);
                x += 40;
                y += 40;
                k += 30;
                j += 30;
                N--;
                MyDraw(g, N, x, y, k, j);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MyDraw(g, 7, 50, 50, 0, 0);
        }


    }
}