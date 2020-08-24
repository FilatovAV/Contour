using System.ComponentModel.DataAnnotations.Schema;
using Contour.Domain.Base;
using Contour.Domain.Base.Abstractions;

namespace Contour.Domain.Entities
{
    [Table("Purposes")]
    public class Purpose : BaseEntity, IPurpose
    {
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
        public int PurposeTypeNameId { get; set; }
        public virtual PurposeTypeName PurposeTypeName { get; set; }
    }
}
