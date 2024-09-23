namespace Lab1_bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timBtt_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(tBnhap1.Text, out _)) && (double.TryParse(tBnhap2.Text, out _)) && (double.TryParse(tBnhap3.Text, out _)))
            {
                double a = Convert.ToDouble(tBnhap1.Text);
                double b = Convert.ToDouble(tBnhap2.Text);
                double c = Convert.ToDouble(tBnhap3.Text);
                double max = a;
                if (b > max) max = b;
                if (c > max) max = c;                  
                double min = a;                           
                if (b < min) min = b;
                if (c < min) min = c;
                tBxuat1.Text = Convert.ToString(max);
                tBxuat2.Text = Convert.ToString(min);
            }
            else
                MessageBox.Show("Input không hợp lệ \nPhải điền đầy đủ các inputs\nChỉ chấp nhận inputs là số thực ");

        }

        private void xoaBtt_Click(object sender, EventArgs e)
        {
            tBnhap1.Text = null;
            tBnhap2.Text = null;
            tBnhap3.Text = null;
        }

        private void escBtt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
