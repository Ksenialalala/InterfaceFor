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
            int x, y;
            try
            {
                x = int.Parse(this.NumberX.Text);
                y = int.Parse(this.NumberY.Text);
            }
            catch (FormatException)
            {
                return;
            }
            

            Properties.Settings.Default.NumberX = x;
            Properties.Settings.Default.NumberY = y;
            Properties.Settings.Default.Save();

            int result = Logic.Multiply(x, y);

            MessageBox.Show(result.ToString());
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
