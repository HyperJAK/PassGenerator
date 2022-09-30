using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PassGenerator
{
    public partial class Form1 : Form
    {
        int lowerCounter = 0;
        int upperCounter = 0;
        int numberCounter = 0;
        int symbolCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void passLengthText_Click(object sender, EventArgs e)
        {

        }

        private void sliderPassLength_Scroll(object sender, EventArgs e)
        {
            Generator.passLength = sliderPassLength.Value;//gets value of slider
            passLengthText.Text = ("Current password length: " + Generator.passLength);
        }

        private void lowercaseLabel_Click(object sender, EventArgs e)
        {
            if (lowerCounter % 2 == 0)
            {
                Generator.lowerCase = true;
                lowercaseLabel.BackColor = Color.BlueViolet;
                lowerCounter++;
            }
            else
            {
                Generator.lowerCase = false;
                lowercaseLabel.BackColor = Color.MidnightBlue;
                lowerCounter++;
                if (lowerCounter >= 3)
                {
                    lowerCounter = 2;
                }
            }
        }

        private void uppercaseLabel_Click(object sender, EventArgs e)
        {

            if (upperCounter % 2 == 0)
            {
                Generator.upperCase = true;
                uppercaseLabel.BackColor = Color.BlueViolet;
                upperCounter++;
            }
            else
            {
                Generator.upperCase = false;
                uppercaseLabel.BackColor = Color.MidnightBlue;
                upperCounter++;
                if (upperCounter >= 3)
                {
                    upperCounter = 2;
                }
            }

        }

        private void numbersLabel_Click(object sender, EventArgs e)
        {

            if (numberCounter % 2 == 0)
            {
                Generator.numbers = true;
                numbersLabel.BackColor = Color.BlueViolet;
                numberCounter++;
            }
            else
            {
                Generator.numbers = false;
                numbersLabel.BackColor = Color.MidnightBlue;
                numberCounter++;
                if (numberCounter >= 3)
                {
                    numberCounter = 2;
                }
            }
        }

        private void symbolsLabel_Click(object sender, EventArgs e)
        {

            if (symbolCounter % 2 == 0)
            {
                Generator.symbols = true;
                symbolsLabel.BackColor = Color.BlueViolet;
                symbolCounter++;
            }
            else
            {
                Generator.symbols = false;
                symbolsLabel.BackColor = Color.MidnightBlue;
                symbolCounter++;
                if (symbolCounter >= 3)
                {
                    symbolCounter = 2;
                }
            }
        }

        private async void generateButton_Click(object sender, EventArgs e)
        {
            if (Generator.lowerCase || Generator.upperCase || Generator.numbers || Generator.symbols)
            {
                Generator.createPassword();
                textBoxResult.Text = Generator.pass;
            }
            else
            {
                for(int i = 0; i < 4; i++)
                {
                    //Marks the unmarked items
                    changeColor(Color.Red);

                    await Task.Delay(50);

                    changeColor(Color.MidnightBlue);
                }

            }
        }

        public void changeColor(Color col)
        {
            lowercaseLabel.BackColor = col;
            uppercaseLabel.BackColor = col;
            numbersLabel.BackColor = col;
            symbolsLabel.BackColor = col;
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Generator.pass);
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
