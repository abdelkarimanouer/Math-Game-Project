using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MathGame
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private string GetLevel()
        {
            if (cbLevel.SelectedItem == null)
            {
                return "Easy";
            }

            return cbLevel.SelectedItem.ToString();
        }

        private string GetOperator()
        {
            if (cbOperator.SelectedItem == null)
            {
                return "+";
            }

            return cbOperator.SelectedItem.ToString();
        }

        private string GetRounds()
        {
            if (cbRounds.SelectedItem == null)
            {
                return "3";
            }
            else
            {
                return cbRounds.SelectedItem.ToString() ;
            }
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            cbLevel.SelectedIndex = 0;
            cbOperator.SelectedIndex = 0;
            cbRounds.SelectedIndex = 2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMathGame frmMathGame = new frmMathGame(GetLevel(), GetOperator(), GetRounds() );
            frmMathGame.Show();

            
        }

    }
}
