using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contour.Domain.Base.Abstractions
{
    public interface IGroup
    {
        string Name { get; set; }
        string Description { get; set; }
        string Url { get; set; }
        int GroupStatus { get; set; }
        int GroupState { get; set; }
        int UserId { get; set; }
        DateTime CreateDate { get; set; }
        int LocationId { get; set; }
    }
}
