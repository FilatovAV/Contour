using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contour.Domain.Base.Abstractions
{
    public interface ILocation
    {
        string Name { get; set; }
        string Description { get; set; }
    }
}
