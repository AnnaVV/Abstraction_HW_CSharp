using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player();
            myPlayer.Play();
            myPlayer.Record();

            Console.ReadLine();
        }
    }
}
