using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleEngine
{
    public interface IConvertibleToOut<To>
    {
        public To ConvertTo(out To to);
    }
}
