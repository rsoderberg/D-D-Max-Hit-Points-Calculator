using System;

namespace DND_Max_Hit_Points_Calculator
{
    class Dice
    {
        private static Random rolledSide = new Random();

        public string Roll(int die, string currentLevel)
        {
            calculateMaxHPForm.OutputHandler.PrintResult($"Rolling a d{die}.....");

            int roll = 0;

            if (currentLevel == "0")
            {
                roll = die;
            }
            else
            {
                roll = rolledSide.Next(1, die);
            }

            calculateMaxHPForm.OutputHandler.PrintResult($"You rolled: {roll}{Environment.NewLine}");

            return Convert.ToString(roll);
        }
    }
}
