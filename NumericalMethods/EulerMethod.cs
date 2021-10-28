using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_F21.NumericalMethods
{
    class EulerMethod : NumericalMethod
    {
        public new double[] x, y;
        public double[] error;
        public EulerMethod(int N, double x0, double y0, double X) : base(N, x0, y0, X)
        {
            x = new double[N + 1];
            y = new double[N + 1];
            error = new double[N + 1];
            x[0] = x0;
            y[0] = y0;
        }
        public new double Calculate()
        {
            double maxError = 0;
            for (int i = 1; i < N; i++)
            {
                x[i] = x[i - 1] + h;
                y[i] = y[i - 1] + h * F(x[i - 1], y[i - 1]);

                error[i] = Math.Abs(Exact(x[i]) - y[i]);
                maxError = Math.Max(maxError, error[i]);
            }
            return maxError;
        }
    }
}

