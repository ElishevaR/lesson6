using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.BL
{
    public interface IPeopleService
    {
        List<People> getAll();
    }
}
