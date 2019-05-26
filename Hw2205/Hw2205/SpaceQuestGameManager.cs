using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2205
{
    class SpaceQuestGameManager
    {
        private int _goodSpaceShipHitPoints;
        private int _shipXLocation;
        private int _shipYLocation;
        private int _numberOfBadShips;
        public int _currentLevel;

        public event EventHandler<PointsEventArgs> GoodSpaceSchipHPChanged;
        public event EventHandler<LocationEventArgs> GoodSpaceShipLocationChanged;
        public event EventHandler<LocationEventArgs> GoodSpaceShipDestroyed;
        public event EventHandler<BadShipExplodedEventArgs> BadShipExploded;
        public event EventHandler<LevelEventArgs> LevelUpReached;

        public SpaceQuestGameManager(int _goodSpaceShipHitPoints, int _shipXLocation, int _shipYLocation, int _numberOfBadShips)
        {
            this._goodSpaceShipHitPoints = _goodSpaceShipHitPoints;
            this._shipXLocation = _shipXLocation;
            this._shipYLocation = _shipYLocation;
            this._numberOfBadShips = _numberOfBadShips;
        }

        public void MoveSpaceShip(int newX, int newY)
        {

        }
        public void GoodSpaceShipGotDamaged(int damage)
        {

        }
        public void GoodSpaceShipGotExtreHP(int extra)
        {

        }
        public void EnemyShipsDestroyed(int numberOfBadShipsDestroyed)
        {

        }

        private void OnGoodSpaceShipHpChanged()
        {

        }
        private void OnGoodShipLocationChanged()
        {

        }
        private void OnGoodSpaceShipDestroyed()
        {

        }
        private void OnBadShipExploded()
        {

        }
        private void OnLevelUpReached()
        {

        }

    }
}
