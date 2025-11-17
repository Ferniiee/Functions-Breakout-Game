using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions_Breakout_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global variable (i.e., modular variable)
        int movesCounter = 0;

        private void btnReset_Click(object sender, EventArgs e)
        {
            gameSetup();
            enableButtons();
            movesCounter = 0;
            lblMoves.Text = Convert.ToString(movesCounter);
        }

        void swap(ref Button myButton)
        {
            if (myButton.BackColor.Equals(Color.Red))
            {
                myButton.BackColor = Color.White;
            }
            else
            {
                myButton.BackColor = Color.Red;
            }
        }

        void gameSetup()
        {
            Random randGen = new Random();

            //generate a random color for btn1
            if (randGen.Next(0,2) == 0)
            {
                btn1.BackColor = Color.Red;
            }
            else
            {
                btn1.BackColor = Color.White;
            }

            //generate a random color for btn1
            if (randGen.Next(0, 2) == 0)
            {
                btn2.BackColor = Color.Red;
            }
            else
            {
                btn2.BackColor = Color.White;
            }

            //generate a random color for btn3
            if (randGen.Next(0, 2) == 0)
            {
                btn3.BackColor = Color.Red;
            }
            else
            {
                btn3.BackColor = Color.White;
            }

            //generate a random color for btn4
            if (randGen.Next(0, 2) == 0)
            {
                btn4.BackColor = Color.Red;
            }
            else
            {
                btn4.BackColor = Color.White;
            }
            //generate a random color for btn5
            if (randGen.Next(0, 2) == 0)
            {
                btn5.BackColor = Color.Red;
            }
            else
            {
                btn5.BackColor = Color.White;
            }
            //generate a random color for btn6
            if (randGen.Next(0, 2) == 0)
            {
                btn6.BackColor = Color.Red;
            }
            else
            {
                btn6.BackColor = Color.White;
            }
            //generate a random color for btn7
            if (randGen.Next(0, 2) == 0)
            {
                btn7.BackColor = Color.Red;
            }
            else
            {
                btn7.BackColor = Color.White;
            }
            //generate a random color for btn8
            if (randGen.Next(0, 2) == 0)
            {
                btn8.BackColor = Color.Red;
            }
            else
            {
                btn8.BackColor = Color.White;
            }
            //generate a random color for btn9
            if (randGen.Next(0, 2) == 0)
            {
                btn9.BackColor = Color.Red;
            }
            else
            {
                btn9.BackColor = Color.White;
            }

            movesCounter = 0;
            lblMoves.Text = Convert.ToString(movesCounter);
            //void gameSetup()
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameSetup();
        }

        void disabledButtons()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        void enableButtons()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        void checkForWin()
        {
            if (btn1.BackColor == btn2.BackColor &&
                btn1.BackColor == btn3.BackColor &&
                btn1.BackColor == btn4.BackColor &&
                btn1.BackColor == btn5.BackColor &&
                btn1.BackColor == btn6.BackColor &&
                btn1.BackColor == btn7.BackColor &&
                btn1.BackColor == btn8.BackColor &&
                btn1.BackColor == btn9.BackColor)
            {
                disabledButtons();
            }
        }

        void incrementMovesCheckForWin()
        {
            movesCounter = movesCounter + 1;
            lblMoves.Text = Convert.ToString(movesCounter);
            checkForWin();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //1,2,4
            swap(ref btn1);
            swap(ref btn2);
            swap(ref btn4);

            incrementMovesCheckForWin();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //1,2,3,5
            swap(ref btn1);
            swap(ref btn2);
            swap(ref btn3);
            swap(ref btn5);

            incrementMovesCheckForWin();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //2,3,6
            swap(ref btn2);
            swap(ref btn3);
            swap(ref btn6);
            

            incrementMovesCheckForWin();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //1,4,5,7
            swap(ref btn1);
            swap(ref btn4);
            swap(ref btn5);
            swap(ref btn7);

            incrementMovesCheckForWin();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //2,4,5,6,8,
            swap(ref btn2);
            swap(ref btn4);
            swap(ref btn5);
            swap(ref btn6);
            swap(ref btn8);

            incrementMovesCheckForWin();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //3,5,6,9
            swap(ref btn3);
            swap(ref btn5);
            swap(ref btn6);
            swap(ref btn9);

            incrementMovesCheckForWin();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //4,7,8
            swap(ref btn4);
            swap(ref btn7);
            swap(ref btn8);

            incrementMovesCheckForWin();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //5,7,8,9
            swap(ref btn5);
            swap(ref btn7);
            swap(ref btn8);
            swap(ref btn9);

            incrementMovesCheckForWin();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //6,8,9
            swap(ref btn6);
            swap(ref btn8);
            swap(ref btn9);

            incrementMovesCheckForWin();
        }
    }
}
