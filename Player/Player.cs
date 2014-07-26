using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("I'm playing now");
        }
        public void Record()
        {
            Console.WriteLine("I'm recording now");
        }
        public void Stop()
        {
            Console.WriteLine("I'm stopped now");
        }
        public void Pause()
        {
            Console.WriteLine("I'm paused now");
        }
    }
}
