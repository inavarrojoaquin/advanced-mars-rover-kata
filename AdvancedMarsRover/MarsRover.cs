using System;

namespace AdvancedMarsRover
{
    public class MarsRover
    {
        private Plateu plateu;

        public string Execute(string input)
        {
            plateu = new Plateu();
            plateu.Move(input);

            return plateu.Print();
        }
    }
}