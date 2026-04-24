namespace homework_6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);
            DateTime startDate = new DateTime(year, 1, 1);
            DateTime endDate = new DateTime(year, 12, 31);
            int saturdayCount = 0;
            int sundayCount = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    saturdayCount++;
                }
                else if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
            }
            label1.Text = ($"星期六 {saturdayCount} 天, 星期日 {sundayCount} 天");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text) + 1911;
            DateTime startDate = new DateTime(year, 1, 1);
            DateTime endDate = new DateTime(year, 12, 31);
            int saturdayCount = 0;
            int sundayCount = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    saturdayCount++;
                }
                else if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
            }
            label1.Text = ($"星期六 {saturdayCount} 天, 星期日 {sundayCount} 天");
        }
    }
}
