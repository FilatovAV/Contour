using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Spatial;
using Contour.Domain.Base;
using Contour.Domain.Base.Abstractions;

namespace Contour.Domain.Entities
{
    public class Contour : BaseEntity, IContour
    {
        [Required]
        [StringLength(1000)]
        public string Name { get; set; }
        public string Description { get; set; }
        [StringLength(100)]
        public string LineType { get; set; }
        /// <summary>  0 - внутренний, 1 - внешний </summary>
        public int ContourType { get; set; }
        /// <summary> 0 - площадной, 1 - линейный </summary>
        public int ContourKind { get; set; }
        public int? ParentId { get; set; }
        public int GroupId { get; set; }
        public int BorderColorId { get; set; }
        public int? FillColorId { get; set; }
        public DbGeometry Geometry { get; set; }
        public virtual ContourColor BorderColor { get; set; }
        public virtual ContourColor FillColor { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
