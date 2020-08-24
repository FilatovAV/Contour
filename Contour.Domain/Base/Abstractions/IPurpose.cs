using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contour.Domain.Base.Abstractions
{
    public interface IPurpose
    {
        int GroupId { get; set; }
        int PurposeTypeNameId { get; set; }
    }
}
