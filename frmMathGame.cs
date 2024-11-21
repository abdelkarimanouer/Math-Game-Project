using MathGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class frmMathGame : Form
    {

        private string _level;
        private string _Operator;
        private byte _Rounds;
        public frmMathGame(string level, string Op, string Rounds)
        {
            InitializeComponent();
            _level = level;
            _Operator = Op;
            _Rounds = Convert.ToByte(Rounds);
        }

        private byte CountRound = 1;
        private byte CountTimer = 30;
        private int N1 = 0;
        private int N2 = 0;
        private float Answer = 0;
        private byte WinTime = 0;
        private byte FailTime = 0;

        private void GetNumbers()
        {
            Random rnd = new Random();

            if (_level == "Easy")
            {
                N1 = rnd.Next(1, 10);
                N2 = rnd.Next(1, 10);

                lbNumber1.Text = N1.ToString();
                lbNumber2.Text = N2.ToString();
            }

            else if (_level == "Medium")
            {
                N1 = rnd.Next(11, 50);
                N2 = rnd.Next(11, 50);

                lbNumber1.Text = N1.ToString();
                lbNumber2.Text = N2.ToString();

            }

            else if (_level == "Hard")
            {
                N1 = rnd.Next(51, 100);
                N2 = rnd.Next(51, 100);

                lbNumber1.Text = N1.ToString();
                lbNumber2.Text = N2.ToString();
            }

            else
            {
                N1 = rnd.Next(1, 100);
                N2 = rnd.Next(1, 100);

                lbNumber1.Text = N1.ToString();
                lbNumber2.Text = N2.ToString();
            }

        }

        private int RightAnswer()
        {

            switch(_Operator)
            {
                case "+":
                    return N1 + N2;
                case "-":
                    return N1 - N2;
                case "*":
                    return N1 * N2;
                case "/":
                    return N1 / N2;
            }
            return 0;
        }

        private bool CheckAnswer()
        {

            if (Answer == RightAnswer())
            {
                pbBoyThinking.Image = Resources.Yes;
                pbImojiThinking.Image = Resources.Right;
                WinTime++;
                return true;
            }  
            else
            {
                pbBoyThinking.Image = Resources.No;
                pbImojiThinking.Image = Resources.False_X;
                FailTime++;
                return false;
            }

        }

        private void frmMathGame_Load(object sender, EventArgs e)
        {
            lbLevel.Text = _level;
            lbRound.Text = CountRound.ToString() + "/" + _Rounds.ToString();
            lbOperator.Text = _Operator;   

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmResult Result = new frmResult(_level, _Operator, _Rounds, WinTime, FailTime);
            Result.Show();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            
            txtbResult.ReadOnly = false;
            GetNumbers();
            btnStartGame.Enabled = false;

            timer1.Start();

        }

        private void Reset()
        {
            txtbResult.Clear();
            lbPlayerAnswer.Text = "0";
            CountTimer = 30;
            lbRightAnswer.Text = "0";
            pbBoyThinking.Image = Resources.Premium_Vector___Man_character_thinking;
            pbImojiThinking.Image = Resources.thinking;
        }

        private void NextQuastion()
        {

            CountRound++;

            if (CountRound <= _Rounds)
            {
                GetNumbers();
                lbRound.Text = CountRound.ToString() + "/" + _Rounds.ToString();
            }
            else
            {
                panel1.Enabled = false;
                btnReset.Enabled = true;
            }

            Reset();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnCheckAnswer.Enabled = true;
            btnNext.Enabled = false;
            if (string.IsNullOrWhiteSpace(txtbResult.Text))
            {
                errorProvider1.SetError(txtbResult, "Please Enter Answer First");
                return;
            }

            NextQuastion();
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e) 
        {
            btnNext.Enabled = true;

            if (string.IsNullOrWhiteSpace(txtbResult.Text) )
            {
                errorProvider1.SetError(txtbResult, "Please Enter Answer First") ;
                return;
            }

            Answer = Convert.ToSingle(txtbResult.Text);
            lbPlayerAnswer.Text = txtbResult.Text;
            lbRightAnswer.Text = RightAnswer().ToString();
            CheckAnswer();

            btnCheckAnswer.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnStartGame.Enabled = true;
            panel1.Enabled = true;

            GetNumbers();

            WinTime = 0;
            FailTime = 0;
            CountRound = 1;
            lbRound.Text = CountRound.ToString() + "/" + _Rounds.ToString();

            Reset();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CountTimer == 0)
            {
                timer1.Stop();
                CountTimer = 30;

                NextQuastion();

            }

            lbTime.Text = CountTimer.ToString();
            CountTimer--;

            if (CountRound > _Rounds)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }

        }

        private void txtbResult_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
   
    
    }
}
