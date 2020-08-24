using System.ComponentModel.DataAnnotations;
using Contour.Domain.Base;
using Contour.Domain.Base.Abstractions;

namespace Contour.Domain.Entities
{
    //ColorMethod
    //ByLayer = 192,        // 0x000000C0
    //ByBlock = 193,        // 0x000000C1
    //ByColor = 194,        // 0x000000C2
    //ByAci = 195,          // 0x000000C3
    //ByPen = 196,          // 0x000000C4
    //Foreground = 197,     // 0x000000C5
    //LayerOff = 198,       // 0x000000C6
    //LayerFrozen = 199,    // 0x000000C7
    //None = 200,           // 0x000000C8
    public class ContourColor : BaseEntity, IContourColor
    {
        public int ColorMethod { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
        public short ColorIndex { get; set; }
        [StringLength(100)]
        public string ColorValueName { get; set; }
        public int ContourId { get; set; }
    }
}
