using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Surface : ISurface, ICollidableSurface, IObserver<CarInfo>
    {
        private List<CarInfo> ObservableCars { get; }
        public long Height { get; }

        public long Width { get; }

        public Surface(long width, long height)
        {
            Width = width;
            Height = height;
            ObservableCars = new List<CarInfo>();
        }
        public bool IsCoordinatesEmpty(Coordinates coordinates)
        {
            bool value = true;
            for (int i = 0; i < ObservableCars.Count(); i++)
            {
                if (ObservableCars[i].Coordinates.Equals(coordinates))
                {
                    value = false;
                    throw new Exception();
                }
            }
            return value;
        }

        public bool IsCoordinatesInBounds(Coordinates coordinates)
        {
            IsCoordinatesEmpty(coordinates);

            if (coordinates.X > Width || coordinates.Y > Height || coordinates.X < 0 || coordinates.Y < 0)
                return false;
            else
                return true;
        }

        public void Update(CarInfo provider)
        {
                if (ObservableCars.Contains(provider))
                {
                    for (int i = 0; i < ObservableCars.Count(); i++)
                    {
                        if (ObservableCars[i].CarId == provider.CarId)
                        {
                            ObservableCars[i] = provider;
                        }
                    }
                }
            
            else
                ObservableCars.Add(provider);

        }

        public List<CarInfo> GetObservables()
        {
            List<CarInfo> newList = new List<CarInfo>();

            if (ObservableCars == null)
            {
                return newList;
            }
            else
            {
                foreach (var cars in ObservableCars)
                {
                    newList.Add(cars);
                }
                return newList;
            }

        }

    }
}
