using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_F21.NumericalMethods
{
    class RungeKutta : NumericalMethod
    {
        public new double[] x, y;
        public double[] e;
        public RungeKutta(int N, double x0, double y0, double X) : base(N, x0, y0, X)
        {
            x = new double[N + 1];
            y = new double[N + 1];
            e = new double[N + 1];
            x[0] = x0;
            y[0] = y0;
        }

        public new double Calculate()
        {
            x[0] = x0;
            y[0] = y0;
            double maxError = 0;
            //yn+1 = yn + h * T4(xn, yn)
            for(int i = 1; i < N; i++)
            {
                x[i] = h + x[i-1];
                y[i] = y[i - 1] + h * T4(x[i - 1], y[i - 1]);
                e[i] = Math.Abs(y[i] - Exact(x[i]));
                maxError = Math.Max(e[i], maxError);
            }
            return maxError;
        }
        public  double T4(double x, double y)
        {
            double T4, k1, k2, k3, k4;
            k1 = F(x, y);
            k2 = F(x + h / 2, y + h * k1 / 2);
            k3 = F(x + h / 2, y + h * k2/ 2);
            k4 = F(x + h, y + h * k3);
            T4 = (k1 + 2 * k2 + 2 * k3 + k4) / 6;
            return T4;

        }
    }
}
