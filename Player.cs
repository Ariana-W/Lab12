using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{ 
        public interface IPlayer
        {

            //StoreName 
            string Name();

            
            //Store roshambo

            string GenerateRoshambo();
        }

    public class PlayerThree : IPlayer
    {
        //StoreName 
        public string Name()
        {          
            string a = "Jermale";
            return a;   
        }

        //Store Roshambo

        public string GenerateRoshambo()
        {
            PlayerTwo PlayerTwoChoice = new PlayerTwo();
            //Return method will print out random value
            return Name().ToLower() + PlayerTwoChoice.GenerateRoshambo();                   
        }

    }
}

