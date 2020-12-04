using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_calculator
{
    public partial class Window : Form
    {
        bool isAnswer = false;
        bool isDouble;
        bool isOperatorPerformed = false;
        bool isLeftBracket = false;
        bool isRightBracket = false;
        public Window()
        {
            InitializeComponent();
        }

        private void input_number(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            isOperatorPerformed = false;
            if ((active_box.Text == "0") || isAnswer == true)
            {
                isAnswer = false;
                active_box.Clear();
                passive_box.Text = "";
                active_box.Text = active_box.Text + button.Text;
            }
            else
            {
                active_box.Text = active_box.Text + button.Text;
            }
        }


        private void input_operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isAnswer || isOperatorPerformed == false)
            {
                isAnswer = false;
                isDouble = false;
                if (!active_box.Text.Contains(")") && active_box.Text.Contains("("))
                {
                    active_box.Text = active_box.Text + button.Text;

                    isOperatorPerformed = true;
                    isRightBracket = false;
                }
                else if (!active_box.Text.Contains(")") && !active_box.Text.Contains("("))
                {
                    if((active_box.Text == "0" || active_box.Text == "") && button.Text == "-")
                    {
                        active_box.Text = button.Text + active_box.Text;
                    }
                    else if((active_box.Text == "0" || active_box.Text == "") && (button.Text == "+" || button.Text == "*" || button.Text == "/"))
                    {
                        active_box.Text = "";
                    }
                    else
                    {
                        passive_box.Text = passive_box.Text + active_box.Text + button.Text;
                        isOperatorPerformed = true;
                        active_box.Clear();
                    }
                }
                else
                {
                    passive_box.Text = active_box.Text + button.Text;
                    isOperatorPerformed = true;
                    active_box.Clear();
                }

            }
            else if (isOperatorPerformed == false)
            {
                isDouble = false;
                passive_box.Text = passive_box.Text + active_box.Text + button.Text;
                isOperatorPerformed = true;
                active_box.Clear();
            }
        }

        private void input_equal(object sender, EventArgs e)
        {
            if (!active_box.Text.EndsWith(")") && active_box.Text.Contains("("))
            {
                active_box.Text = active_box.Text + ")";
                passive_box.Text = passive_box.Text + active_box.Text;
            }
            else if (active_box.Text.EndsWith(")") && active_box.Text.Contains("("))
            {
                passive_box.Text = passive_box.Text + active_box.Text;
            }
            else
            {
                passive_box.Text = passive_box.Text + active_box.Text;
            }
            active_box.Clear();

            if (passive_box.Text.EndsWith("/0"))
            {
                active_box.Text = "Undefined.";
            }
            else
            {
                calculate(passive_box.Text);
            }
        }

        private void input_clear(object sender, EventArgs e)
        {
            isAnswer = false;
            isDouble = false;
            isOperatorPerformed = false;
            if (active_box.Text == "")
            {
                passive_box.Text = "";
            }
            else
            {
                active_box.Clear();
            }
        }
        private void calculate(string passiveBox)
        {
                string value = new DataTable().Compute(passiveBox, null).ToString();
                active_box.Text = value;
                passive_box.Text = "";
                isAnswer = true;
        }

        private void input_dot_operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!isDouble)
            {
                active_box.Text = active_box.Text + button.Text;
                isDouble = true;
            }
        }

        private void input_brackets(object sender, EventArgs e)
        {
            isLeftBracket = active_box.Text.Contains("(");
            isRightBracket = active_box.Text.Contains(")");
            if (active_box.Text.EndsWith("0") || active_box.Text.EndsWith("1") ||
                active_box.Text.EndsWith("2") || active_box.Text.EndsWith("3") ||
                active_box.Text.EndsWith("4") || active_box.Text.EndsWith("5") ||
                active_box.Text.EndsWith("6") || active_box.Text.EndsWith("7") ||
                active_box.Text.EndsWith("8") || active_box.Text.EndsWith("9")
                )
            {
                if (!isLeftBracket && !isRightBracket)
                {
                    active_box.Text = active_box.Text + "*(";
                    isLeftBracket = true;
                }
                else if (isLeftBracket && !isRightBracket)
                {
                    active_box.Text = active_box.Text + ")";
                    isRightBracket = true;
                }
            }
        }

        private void input_changeSign(object sender, EventArgs e)
        {
            active_box.Text = active_box.Text + "* (-1)";
            string value = new DataTable().Compute(active_box.Text, null).ToString();
            active_box.Text = value;
        }

        private void input_backspace(object sender, EventArgs e)
        {
            if (active_box.Text != "")
            {
                active_box.Text = active_box.Text.Substring(0, active_box.Text.Length - 1);
            }
        }
    }

}