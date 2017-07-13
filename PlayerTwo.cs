using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class PlayerTwo
    {       
        public string GenerateRoshambo()
        {
                       
                Random random = new Random();

                int randomNumber = random.Next(1, 3);

                    string a = " ";

            if (randomNumber == 1)
            {

                a = "rock";
            }

            else if (randomNumber == 2)
            {
                a = "paper";

            }

            else if (randomNumber == 3)
            {
                a = " sciccors";
            }

                 return a;

        }

        /*
        public string PlayerTwoName()
        {
            string b = "Shekara";

            return b;
        }

        */
    }
}
