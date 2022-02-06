using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeric
{
    public interface ISdeMethod
    {
        double NextStep(double x0, double A, double B, double dW, double dt);
        //Milstein方法ではオーバーライドが必要になる。

    }
}
