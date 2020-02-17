using System;
using System.Windows.Forms;

namespace DND_Max_Hit_Points_Calculator
{
    public partial class calculateMaxHPForm : Form
    {
        public static calculateMaxHPForm OutputHandler;

        public calculateMaxHPForm()
        {
            InitializeComponent();
            OutputHandler = this;
        }

        public void PrintResult(string output)
        {
            resultsTextBox.Text = resultsTextBox.Text + output + Environment.NewLine;
            resultsTextBox.Update();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            Dice die = new Dice();

            string rollValue = "";

            if (Convert.ToString(dieComboBox.SelectedItem) == "")
                OutputHandler.PrintResult("Select your hit die before rolling");
            else
            {
                switch (Convert.ToString(dieComboBox.SelectedItem))
                {
                    case "d2":
                        rollValue = die.Roll(2, maxHPTextBox.Text);
                        break;
                    case "d3":
                        rollValue = die.Roll(3, maxHPTextBox.Text);
                        break;
                    case "d4":
                        rollValue = die.Roll(4, maxHPTextBox.Text);
                        break;
                    case "d6":
                        rollValue = die.Roll(6, maxHPTextBox.Text);
                        break;
                    case "d8":
                        rollValue = die.Roll(8, maxHPTextBox.Text);
                        break;
                    case "d10":
                        rollValue = die.Roll(10, maxHPTextBox.Text);
                        break;
                    case "d12":
                        rollValue = die.Roll(12, maxHPTextBox.Text);
                        break;
                    case "d20":
                        rollValue = die.Roll(20, maxHPTextBox.Text);
                        break;
                }

                rollTextBox.Text = rollValue;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(dieComboBox.SelectedItem) == "")
                OutputHandler.PrintResult("Select your hit die and roll before calculating HP");
            if (rollTextBox.Text == "")
                OutputHandler.PrintResult("Select your hit die and roll before calculating HP");

            var newMaxHP = Convert.ToInt32(rollTextBox.Text) + Convert.ToInt32(constModTextBox.Text) + Convert.ToInt32(maxHPTextBox.Text);

            OutputHandler.PrintResult($"({rollTextBox.Text} + {constModTextBox.Text}) + {maxHPTextBox.Text} = {newMaxHP}{Environment.NewLine}");

            maxHPTextBox.Text = Convert.ToString(newMaxHP);
        }
    }
}
