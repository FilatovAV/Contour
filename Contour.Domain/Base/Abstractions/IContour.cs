using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contour.Domain.Entities;

namespace Contour.Domain.Base.Abstractions
{
    public interface IContour
    {
        string Name { get; set; }
        string Description { get; set; }
        string LineType { get; set; }
        /// <summary>  0 - внутренний, 1 - внешний </summary>
        int ContourType { get; set; }
        /// <summary> 0 - площадной, 1 - линейный </summary>
        int ContourKind { get; set; }
        int? ParentId { get; set; }
        int GroupId { get; set; }
        int BorderColorId { get; set; }
        int? FillColorId { get; set; }
        DbGeometry Geometry { get; set; }
    }
}
