using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace homework_6_2
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
            int day = DateTime.IsLeapYear(year) ? 366 : 365;
            DateTime startDate = new DateTime(year, 1, 1);
            int week = (int)startDate.DayOfWeek;
            // 365天/7 = 52...1 
            int saturdayCount = 52;
            int sundayCount = 52;
            if (year==366 && week == 6)
            {
                saturdayCount++;
                sundayCount++;
            }
            else if (week == 6)
            {
                saturdayCount++;               
            }
            else if (week == 0)
            {
                sundayCount++;
            }

            
            label1.Text = ($"星期六 {saturdayCount} 天, 星期日 {sundayCount} 天");
        }
    }
}
