using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Hw2205
{
    class Program
    {
        private static SpaceQuestGameManager game;
        private static Random r = new Random();


        static void Main(string[] args)
        {
            game = new SpaceQuestGameManager(100, 5, 5, 10);
            GameViewer viewer = new GameViewer();

            game.GoodSpaceShipLocationChanged += viewer.GoodSpaceShipLocationChangedEventHandler;
            game.MoveSpaceShip(10, 10);

            game.LevelUpReached += viewer.LevelUpReachedEventHandler;
            game.GoodSpaceShipHPChanged += viewer.GoodSpaceShipHpChangedEventHandler;



            //Timer t = new Timer();
            //t.Interval = 1000;
            //t.Elapsed += ElapsedEventHandler;
            //t.Start();
            //while(true)
            //{
                
            //}
        }

        private static void ElapsedEventHandler(object sender, ElapsedEventArgs e)
        {
            game.MoveSpaceShip(r.Next(1000), r.Next(1000));
        }
    }
}
