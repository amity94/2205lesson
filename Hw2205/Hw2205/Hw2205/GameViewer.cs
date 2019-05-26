using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2205
{
    class GameViewer
    {
        public void GoodSpaceShipHpChangedEventHandler(object sender, PointsEventArgs e)
        {
            Console.WriteLine("");
        }
        public void GoodSpaceShipLocationChangedEventHandler(object sender, LocationEventArgs e)
        {
            Console.WriteLine($"Location changed to {e.X}, {e.Y}");
        }
        public void GoodSpaceShipDestroyedEventHandler(object sender, PointsEventArgs e)
        {
            Console.WriteLine($"Your ship has died, your hp is ow {e.HitPoints}");
        }
        public void BadShipsExplodedEventHandler(object sender, BadShipExplodedEventArgs e)
        {

        }
        public void LevelUpReachedEventHandler(object sender, LevelEventArgs e)
        {
            Console.WriteLine($"You leveled up, you are now level {e.CurrentLevel++}");
        }
    }
}
