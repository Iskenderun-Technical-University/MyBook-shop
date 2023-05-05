using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace MyBook_shop.PL
{
    public partial class MyBook : Form
    {
        public MyBook()
        {
            InitializeComponent();
        }
        private Rectangle originalFormSize;
        private Rectangle Button2OriginalRectangle;
        private Rectangle PictureSize;
        private void MyBook_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            Button2OriginalRectangle = new Rectangle(button12.Location.X, button12.Location.Y, button12.Size.Width, button12.Size.Height);
            PictureSize = new Rectangle(pictureBox8.Location.X, pictureBox8.Location.Y, pictureBox8.Size.Width, pictureBox8.Size.Height);

        }

        private void MyBook_Resize(object sender, EventArgs e)
        {
            resizeControl(Button2OriginalRectangle, button12, button11, button10, button9, button8);
            //ResizePicture(PictureSize, pictureBox8);
        }

        private void ResizePicture(Rectangle r, Control b1)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            b1.Size = new Size(newWidth, newHeight);
        }
        private void resizeControl(Rectangle r, Control b1, Control b2, Control b3, Control b4, Control b5)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            b1.Size = new Size(newWidth, newHeight);
            b2.Size = new Size(newWidth, newHeight);
            b3.Size = new Size(newWidth, newHeight);
            b4.Size = new Size(newWidth, newHeight);
            b5.Size = new Size(newWidth, newHeight);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void P_HOME_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            if (P_MB.Size.Width == 240)
            {
                P_MB.Width = 60;


            }
            else
            {
                P_MB.Width = 240;


            }
        }

        private void P_MB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }


    }
}
