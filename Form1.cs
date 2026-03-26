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
            if (txtTop.Text.Length >= currentNum.Length)
            {
                txtTop.Text = txtTop.Text.Substring(0, txtTop.Text.Length - currentNum.Length);
            }

            // 2. 지금 입력 중인 숫자 메모장만 비웁니다.
            currentNum = "";

            // 3. 아래쪽 결과창은 다시 0으로 보여줍니다.
            txtBottom.Text = "0";
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

        private void button2_Click(object sender, EventArgs e)
        {
            n1 = 0;             // 저장된 첫 번째 숫자 삭제
            currentNum = "";    // 지금 쓰고 있던 숫자 삭제
            op = "";            // 기억하던 연산자(+, -, *, /) 삭제

            txtTop.Text = "";    // 위쪽 텍스트박스 비우기
            txtBottom.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentNum.Length > 0)
            {
                // 1. 메모장(currentNum)에서 맨 뒤 한 글자 삭제
                currentNum = currentNum.Substring(0, currentNum.Length - 1);

                // 2. 위쪽 화면(txtTop)에서도 맨 뒤 한 글자 삭제
                txtTop.Text = txtTop.Text.Substring(0, txtTop.Text.Length - 1);

                // 3. 아래쪽 결과창 업데이트 (다 지워졌으면 0으로 표시)
                txtBottom.Text = (currentNum == "") ? "0" : currentNum;
            }
        }
    }
}
