using System.ComponentModel.DataAnnotations;
using Contour.Domain.Base;
using Contour.Domain.Base.Abstractions;

namespace Contour.Domain.Entities
{
    public class Image : BaseEntity, IImage
    {
        [StringLength(2048)]
        public string Url { get; set; }
        [StringLength(1000)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int ContourId { get; set; }
        public virtual Contour Contour { get; set; }
    }
}
