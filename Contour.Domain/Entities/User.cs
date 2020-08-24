using Contour.Domain.Base;
using System.ComponentModel.DataAnnotations;
using Contour.Domain.Base.Abstractions;

namespace Contour.Domain.Entities
{
    public class User : BaseEntity, IUser
    {
        [Required]
        [StringLength(200)]
        public string FirstName { get; set; }
        [StringLength(200)]
        public string LastName { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(1000)]
        public string SiteKeyId { get; set; }
    }
}
