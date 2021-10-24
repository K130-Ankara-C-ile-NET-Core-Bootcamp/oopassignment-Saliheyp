using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public interface ISurface
    {
        long Height { get; }
        long Width { get; }

        bool IsCoordinatesInBounds(Coordinates coordinates);
    }
}
