using Contour.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Contour.Domain.Base.Abstractions;

namespace Contour.Domain.Entities
{
    public class Group : BaseEntity, IGroup
    {
        public Group()
        {
            Contours = new HashSet<Contour>();
            Purposes = new HashSet<Purpose>();
        }

        [Required]
        [StringLength(1000)]
        public string Name { get; set; }
        public string Description { get; set; }
        [StringLength(2048)]
        public string Url { get; set; }
        public int GroupStatus { get; set; }
        public int GroupState { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime CreateDate { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Purpose> Purposes { get; set; }
        public virtual ICollection<Contour> Contours { get; set; }
    }
}
