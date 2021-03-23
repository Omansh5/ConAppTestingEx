using ConAppPlayerTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleAppTestPlayer
{
    [TestFixture]
    class Program
    {
        public static List<Player> Playerlist()
        {
            List<Player> plylist = new List<Player>
            {
                new Player{PId=1,PName="Kohli",PTeam="India"},
               new Player{PId=2,PName="Warner",PTeam="Australia"},
               new Player{PId=3,PName="ABD",PTeam="S Africa"},
               new Player{PId=4,PName="Guptil",PTeam="New Zealand"},
            };
              return plylist;
        }
        static void Main(string[] args)
        {
        }
    }
}
