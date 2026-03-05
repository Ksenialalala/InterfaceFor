namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.NumberX.Text);
        }
    }
    public class Logic
    {
        public static int Multiply(int x, int y)
        {
            int result = 0;
            for (int i = 0; i < y; i++)
            {
                result = result + x;
            }
            return result;
        }
    }
}
