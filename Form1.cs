namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int n1 = 0;
        string currentNum = "";
        string op = "";
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
            int result = 0; // 결과값을 담을 바구니

            // 🌟 어떤 연산자(op)를 눌렀느냐에 따라 계산기가 머리를 씁니다!
            if (op == "+") result = n1 + n2;
            else if (op == "-") result = n1 - n2;
            else if (op == "*") result = n1 * n2;
            else if (op == "/")
            {
                if (n2 != 0) result = n1 / n2;
                else { MessageBox.Show("0으로 나눌 수 없습니다!"); return; }
            }

            // 결과 출력
            txtTop.Text += "=" + result.ToString();
            txtBottom.Text = result.ToString();

            // 다음 계산을 위해 준비 (필요시)
            currentNum = result.ToString();
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

        private void button17_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(currentNum); op = "-"; txtTop.Text += "-"; currentNum = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(currentNum); op = "*"; txtTop.Text += "*"; currentNum = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(currentNum); op = "/"; txtTop.Text += "/"; currentNum = "";
        }
    }
}
