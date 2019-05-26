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

        public event EventHandler<PointsEventArgs> GoodSpaceShipHPChanged;
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
            _currentLevel = 1;
        }

        public void MoveSpaceShip(int newX, int newY)
        {
            _shipXLocation = newX;
            _shipYLocation = newY;
            OnGoodShipLocationChanged();
        }
        public void GoodSpaceShipGotDamaged(int damage)
        {
            _goodSpaceShipHitPoints -= damage;
            OnGoodSpaceShipHpChanged();
        }
        public void GoodSpaceShipGotExtreHP(int extra)
        {
            _goodSpaceShipHitPoints += extra;
            OnGoodSpaceShipHpChanged();
        }
        public void EnemyShipsDestroyed(int numberOfBadShipsDestroyed)
        {

        }

        private void OnGoodSpaceShipHpChanged()
        {
            if(GoodSpaceShipHPChanged != null)
            {
                GoodSpaceShipHPChanged.Invoke(this, new PointsEventArgs { HitPoints = _goodSpaceShipHitPoints });
            }
        }

        private void OnGoodShipLocationChanged()
        {
            if(GoodSpaceShipLocationChanged != null)
            {
                //LocationEventArgs location = new LocationEventArgs();
                //location.X = _shipXLocation;
                //location.Y = _shipYLocation;
                GoodSpaceShipLocationChanged.Invoke(this, new LocationEventArgs { X = _shipXLocation, Y = _shipYLocation });
            }
        }

        private void OnGoodSpaceShipDestroyed()
        {

        }

        private void OnBadShipExploded()
        {

        }

        private void OnLevelUpReached()
        {
            if(LevelUpReached != null)
            {
                LevelUpReached.Invoke(this, new LevelEventArgs { CurrentLevel = _currentLevel++ });
            }
        }

    }
}
