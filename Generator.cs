using System;
using System.Linq;
using System.Text;

namespace PassGenerator
{
    public class Generator
    {
        public static bool lowerCase = false;
        public static bool upperCase = false;
        public static bool numbers = false;
        public static bool symbols = false;

        public static int passLength = 4;

        public static string pass = "";

        public static void createPassword()
        {
            pass = "";

            string symbls = "!@#$%&*()'+,-./:;<=>?[]^_`{|}";

            Random rnd = new Random();


            while (pass.Length < passLength)
            {
                StringBuilder password = new StringBuilder();
                int randomStart = rnd.Next(4);
                switch (randomStart)
                {
                    case 0:
                        { //lowerCase start
                            if (lowerCase)
                            {
                                char low = (char)(rnd.Next(26) + 'a'); //get random letter from a to z
                                password.Append(low);
                            }
                        }
                        break;
                    case 1:
                        { //upperCase start
                            if (upperCase)
                            {
                                char up = ((char)(rnd.Next(26) + 'a')); // get random letter from A to Z

                                password.Append((up.ToString()).ToUpper());
                            }
                        }
                        break;
                    case 2:
                        { //number start
                            if (numbers)
                            {
                                int rand = (rnd.Next(10));
                                password.Append(rand);
                            }
                        }
                        break;
                    case 3:
                        { //symbol start
                            if (symbols)
                            {
                                char sym = symbls.ElementAt(rnd.Next(symbls.Length));// get random letter from A to Z
                                password.Append(sym);
                            }
                        }
                        break;

                }
                pass += password.ToString();
            }
        }
    }
}
