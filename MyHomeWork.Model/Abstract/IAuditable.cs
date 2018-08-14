using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeWork.Model.Abstract
{
    public interface IAuditable
    {
        int ID { get; set; }
        DateTime? CreateDate { get; set; }
        DateTime? UpdateDate { get; set; }

    }
}
