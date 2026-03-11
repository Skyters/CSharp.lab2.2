namespace CSharp.lab2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numberOfMonths.Text = Properties.Settings.Default.mounthButton.ToString();
            initialPayment.Text = Properties.Settings.Default.initialPaymentButton.ToString();
            limitOfExceedingValue.Text = Properties.Settings.Default.limitOfExceedingValueButton.ToString();
            limitOfExceedingDepositAmount.Text = Properties.Settings.Default.limitOfExceedingDepositAmountButton.ToString();
        }

        public class Logic()
        {
            public static string CalculatingTheContribution(int mounth, double sum, double result1, double result2)
            {
                double newSum = sum;
                double percent; // %
                bool flagRes1 = false;
                bool flagRes2 = false;

                string result = "";

                for (int i = 1; i < mounth + 1; i++)
                {
                    percent = newSum * 0.02;
                    newSum = newSum + percent;

                    if (percent > result1 && !flagRes1)
                    {
                        result += "\nНа " + i + " месяце было превышение";
                        flagRes1 = true;
                    }

                    if (newSum > result2 && !flagRes2)
                    {

                        result += "\nЧерез " + i + " месяцев мы накопим деньги";
                        flagRes2 = true;
                    }

                    result += "\nМесяц " + i + ": " + newSum.ToString("F2") + " руб. " + " " + percent.ToString("F2");
                }

                return result;
            }


        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Гражданин 1 марта открыл счет в банке, вложив A руб. Через каждый месяц размер вклада увеличивается на 2% от имеющейся суммы. Определить: а) за какой месяц величина ежемесячного увеличения вклада превысит B руб.; б) через сколько месяцев размер вклада превысит C руб");
        }

        public void buttonStart_Click(object sender, EventArgs e)
        {

            int mounthButton;
            double initialPaymentButton;
            double limitOfExceedingValueButton;
            double limitOfExceedingDepositAmountButton;

            try
            {
                mounthButton = int.Parse(this.numberOfMonths.Text);
                initialPaymentButton = double.Parse(this.initialPayment.Text);
                limitOfExceedingValueButton = double.Parse(this.limitOfExceedingValue.Text);
                limitOfExceedingDepositAmountButton = double.Parse(this.limitOfExceedingDepositAmount.Text);
                if (mounthButton <= 0 || initialPaymentButton <= 0 || limitOfExceedingValueButton <= 0 || limitOfExceedingDepositAmountButton <= 0)
                {
                    MessageBox.Show("Значения должны быть больше 0");
                    return;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Введите корректное(ые) число(а)");
                return;
            }

            Properties.Settings.Default.mounthButton = mounthButton;
            Properties.Settings.Default.initialPaymentButton = initialPaymentButton;
            Properties.Settings.Default.limitOfExceedingValueButton = limitOfExceedingValueButton;
            Properties.Settings.Default.limitOfExceedingDepositAmountButton = limitOfExceedingDepositAmountButton;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.CalculatingTheContribution(mounthButton, initialPaymentButton, limitOfExceedingValueButton, limitOfExceedingDepositAmountButton));
        }
    }
}
