using System;

namespace unit03_jumper
{
    class Program
    {
        /// <param name="args"> arguments</param>
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
        }
    }
}