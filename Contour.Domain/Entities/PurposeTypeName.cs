using System.ComponentModel.DataAnnotations;
using Contour.Domain.Base;
using Contour.Domain.Base.Abstractions;

namespace Contour.Domain.Entities
{
    public class PurposeTypeName : BaseEntity, IPurposeTypeName
    {
        [Required]
        [StringLength(1000)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
