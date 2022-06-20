using AdvancedMarsRover.Domain;
using System;

namespace AdvancedMarsRover
{
    public class MarsRoverOld
    {
        private Plateu plateu;

        public string Execute(string input)
        {
            plateu = new Plateu();
            plateu.Move(input);

            return plateu.PrintCurrentPosition();
        }
    }
}