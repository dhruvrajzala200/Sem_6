using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    public interface IMovable
    {
        public void Move();
    }

    public interface ISound
    {
        public void Sound();
    }

    public class Robot : IMovable, ISound
    {
        public void Move()
        {
            Console.WriteLine("Moveeeeeeee beta");
        }
        public void Sound()
        {
            Console.Write("Soundddddddd beta");
        }
    }

}
