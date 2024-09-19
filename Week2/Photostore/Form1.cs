using System.Numerics;
using System.Windows.Forms;

namespace Photostore
{
    public partial class Form1 : Form
    {
        Image originalImage;
        public Form1()
        {
            InitializeComponent();


        }
        Image[] img = new Image[10];
        int i = 0;
        int index = 0;
        private void OpenBtt_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (pictureBox1.Image == null)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    pictureBox1.Load(openFileDialog1.FileName);
                    originalImage = pictureBox1.Image;

                }


                foreach (String file in openFileDialog1.FileNames)
                {
                    PictureBox sample = new PictureBox();
                    sample.Height = 100;
                    sample.Width = 100;
                    PictureBox pb = new PictureBox();
                    Image loadedImage = Image.FromFile(file);
                    img[i] = loadedImage;
                    pb.Height = sample.Height;
                    pb.Width = sample.Width;
                    pb.Image = loadedImage;
                    flowLayoutPanel1.Controls.Add(pb);
                    i++;

                }
            }

        }
        private void ClearPic()
        {
            this.pictureBox1.Image = null;
        }

        private void CloseBtt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextBtt_Click(object sender, EventArgs e)
        {
            index++;
            this.pictureBox1.Image = img[index];
            if (index >= i)
                MessageBox.Show("Error: Unvalid Image");
            originalImage = pictureBox1.Image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PrevBtt_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
                MessageBox.Show("Error: Unvalid Image");
            this.pictureBox1.Image = img[index];
            originalImage = pictureBox1.Image;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image flip = pictureBox1.Image;
            flip.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = flip;

        }

        private void clk_rotate_Click(object sender, EventArgs e)
        {
            Image flip = pictureBox1.Image;
            flip.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = flip;
        }
        double zoomFactor = 1.0f;

        private void ZoomImage()
        {
            if (pictureBox1.Image != null)
            {
                int newWidth = (int)(originalImage.Width * zoomFactor);
                int newHeight = (int)(originalImage.Height * zoomFactor);
                Bitmap zoomedImage = new Bitmap(pictureBox1.Image, newWidth, newHeight);
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.Image = zoomedImage;


            }
            else MessageBox.Show("No Image to Zoom");
        }
        private void zominBtt_Click(object sender, EventArgs e)
        {
            zoomFactor += 0.1f;
            ZoomImage();
        }

        private void ZomoutBtt_Click(object sender, EventArgs e)
        {
            if (zoomFactor > 0.1f)
            {
                zoomFactor -= 0.1f;
                ZoomImage();
            }
            else MessageBox.Show("You zoomed too far !_!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zoomFactor = 1.0f;
            ZoomImage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NextBtt_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
