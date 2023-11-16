using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    public interface IStrategy
    {
        void Play(List<Team> team);
    }
}
