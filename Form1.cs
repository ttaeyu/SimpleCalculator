namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int n1 = 0;
        string currentNum = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTop.Text += "1";   // 화면 위쪽에 "1" 찍기
            currentNum += "1";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(currentNum); // 지금까지 쓴 첫 번째 숫자 저장!

            txtTop.Text += "+";         // 위쪽 창에 "+" 이어 붙이기 (예: "1+")

            currentNum = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int n2 = int.Parse(currentNum); // 두 번째 숫자 가져오기
            int sum = n1 + n2;              // 더하기 계산!

            // 🌟 1. 위쪽 창: 기존 식 뒤에 "="과 "결과"를 이어 붙여줍니다. (예: 1+1 뒤에 =2 붙임)
            txtTop.Text += "=" + sum.ToString();

            // 🌟 2. 아래쪽 창: 깔끔하게 "결과" 하나만 딱! 띄워줍니다.
            txtBottom.Text = sum.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtTop.Text += "2";   // 화면 위쪽에 "1" 찍기
            currentNum += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTop.Text += "3";   // 화면 위쪽에 "1" 찍기
            currentNum += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtTop.Text += "4";   // 화면 위쪽에 "1" 찍기
            currentNum += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTop.Text += "5";   // 화면 위쪽에 "1" 찍기
            currentNum += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTop.Text += "6";   // 화면 위쪽에 "1" 찍기
            currentNum += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTop.Text += "7";   // 화면 위쪽에 "1" 찍기
            currentNum += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtTop.Text += "8";   // 화면 위쪽에 "1" 찍기
            currentNum += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTop.Text += "9";   // 화면 위쪽에 "1" 찍기
            currentNum += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtTop.Text += "0";   // 화면 위쪽에 "1" 찍기
            currentNum += "0";
        }
    }
}
