using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorCore
{
    public readonly partial struct Vec4D
    {
        public readonly static Vec4D zero = new Vec4D(0, 0, 0, 0);
        public readonly static Vec4D one = new Vec4D(1, 1, 1, 1);
        public readonly static Vec4D identity = zero;

        //public override string ToString() => $"({x}, {y}, {z}, {w},)";
        //public string ToString(string format) => $"({x.ToString(format)}, {y.ToString(format)},{z.ToString(format)}, {w.ToString(format)})";

    }
}
