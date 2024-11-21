using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class frmResult : Form
    {
        private string _level;
        private string _Operator;
        private byte _Rounds;
        private byte _WinTime = 0;
        private byte _FailTime = 0;

        public frmResult(string Level, string Operator, byte Rounds, byte WinTime, byte FailTime)
        {
            InitializeComponent();
            _level = Level;
            _Operator = Operator;
            _Rounds = Rounds;
            _WinTime = WinTime;
            _FailTime = FailTime;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
            Environment.Exit(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();   
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            lbRounds.Text = _Rounds.ToString();
            lbLevel.Text = _level;
            lbOp.Text = _Operator;
            lbWin.Text = _WinTime.ToString();
            lbFail.Text = _FailTime.ToString();
        }
    }
}
