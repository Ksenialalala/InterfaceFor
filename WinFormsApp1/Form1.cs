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
            var x = int.Parse(this.NumberX.Text);
            var y = int.Parse(this.NumberY.Text);

            Properties.Settings.Default.NumberX = x;
            Properties.Settings.Default.NumberY = y;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.Multiply(x, y).ToString());
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
