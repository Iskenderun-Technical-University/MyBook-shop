using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form1 : Form
    {
        private Rectangle originalFormSize;
        private Rectangle Button2OriginalRectangle;
        private Rectangle PictureSize;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Desktop\BookStore\BookStore\Database.mdf;Integrated Security=True");
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        void excetuequery(string query)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            Button2OriginalRectangle = new Rectangle(button12.Location.X, button12.Location.Y, button12.Size.Width, button12.Size.Height);
            PictureSize = new Rectangle(pictureBox8.Location.X, pictureBox8.Location.Y, pictureBox8.Size.Width, pictureBox8.Size.Height);
            //excetuequery("insert into Usertb values ('"+"Esraa"+"','"+"1234"+ "')");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(Button2OriginalRectangle, button12, button11, button10, button9, button8);
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

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
