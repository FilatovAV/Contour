using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contour.Domain.Base.Abstractions
{
    public interface IContourColor
    {
        int ColorMethod { get; set; }
        byte R { get; set; }
        byte G { get; set; }
        byte B { get; set; }
        short ColorIndex { get; set; }
        string ColorValueName { get; set; }
        int ContourId { get; set; }
    }
}
