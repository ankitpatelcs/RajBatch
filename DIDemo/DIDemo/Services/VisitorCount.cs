using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemo.Services
{
    public class VisitorCount : IVisitorCount
    {
        public int Count { get; set; }
        public int GetCount()
        {
            Count++;
            return Count;
        }
    }
}
