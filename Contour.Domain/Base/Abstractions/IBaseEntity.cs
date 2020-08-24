using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contour.Domain.Base.Abstractions
{
    /// <summary> Сущность (база данных). </summary>
    public interface IBaseEntity
    {
        /// <summary> Идентификатор. </summary>
        int Id { get; set; }
    }
}
