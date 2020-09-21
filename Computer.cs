using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Computer : Player 
    {
        Random random;
        string randomObjectCreated;
        public Computer()
        {
            random = new Random(); 

        }
        public override string ChooseGesture()
        {
            int randomObject = random.Next(0, 5);
            randomObjectCreated = objectList[randomObject];

            return randomObjectCreated; 
        }
    }
}
