using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RPSLS
{
    abstract class Player
    {
        public List<string> objectList;
        
        public Player()
        {
            objectList = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };


        }
        public abstract string ChooseGesture();


       
    }
}
