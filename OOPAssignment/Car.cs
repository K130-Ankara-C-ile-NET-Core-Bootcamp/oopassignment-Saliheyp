using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Car : ICarCommand, IObservable<CarInfo>
    {
        public Guid Id;
        public Coordinates Coordinates;
        public Direction Direction;
        public ISurface Surface;
        private IObserver<CarInfo> Observer;
        public Car(Coordinates coordinates, Direction direction, ISurface surface)
        {
            Coordinates = coordinates;
            Direction = direction;
            Surface = surface;
        }

        public void Attach(IObserver<CarInfo> observer)
        {
            Observer = observer;

            Notify();
        }

        public void Move()
        {
            if (Direction == Direction.N)
            {
                Coordinates.Y++;
            }
            else if (Direction == Direction.S)
            {
                Coordinates.Y--;
            }
            else if (Direction == Direction.E)
            {
                Coordinates.X++;
            }
            else if (Direction == Direction.W)
            {
                Coordinates.X--;
            }
            else
            {
                throw new Exception();
            }

            if (Surface.IsCoordinatesInBounds(Coordinates))
                Notify();
            else
                throw new Exception();
        }

        public void TurnLeft()
        {
            if (Direction == Direction.N)
            {
                Direction = Direction.W;
            }
            else if (Direction == Direction.S)
            {
                Direction = Direction.E;
            }
            else if (Direction == Direction.E)
            {
                Direction = Direction.N;
            }
            else if (Direction == Direction.W)
            {
                Direction = Direction.S;
            }
            else
            {
                throw new Exception();
            }
        }

        public void TurnRight()
        {
            if (Direction == Direction.N)
            {
                Direction = Direction.E;
            }
            else if (Direction == Direction.S)
            {
                Direction = Direction.W;
            }
            else if (Direction == Direction.E)
            {
                Direction = Direction.S;
            }
            else if (Direction == Direction.W)
            {
                Direction = Direction.N;
            }
            else
            {
                throw new Exception();
            }

        }

        public void Notify()
        {
            Observer.Update(new CarInfo(Id, Coordinates));
        }
    }
}
