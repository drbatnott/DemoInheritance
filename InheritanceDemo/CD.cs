using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    /// <summary>
    /// CD inherits from the Media
    /// :base tells the Media to use the constructor we invented
    /// </summary>
    class CD : Media
    {
        float totalLength;
        public CD(string t, string sD,float tl = 70f) : base(t, sD)
        {
            totalLength = tl;
        }
        public float TotalLength
        {
            get { return totalLength; }
        }
    }
}
