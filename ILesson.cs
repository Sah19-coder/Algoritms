using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorims
{
    public interface ILesson
    {
        public string Name { get => Name; }
        public int Id { get => Id; }
        public bool DoTest();
    }
}
