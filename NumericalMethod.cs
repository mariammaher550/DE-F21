using System;
using System.Windows.Forms;

namespace DE_F21
{
    class NumericalMethod
    {
        public double[] x, y;
        public int N; // number of steps
        protected double c, x0, y0, X, h ; //h > step size
        

        //constructor 
        public NumericalMethod(int N, double x0, double y0, double X)
        {
            this.X = X;
            this.x0 = x0;
            this.y0 = y0;
            this.N = N + 1;

            //cases when there is no solution
            if(x0 == 0)
            {
                MessageBox.Show("Solution doesn't exists!");
                Application.Exit();
            }
            // get constant 
            c = -Math.Pow(x0, 2) + y0/Math.Pow(x0, 2);
            //get step size factor
            h = (X - x0) / N;
       
        }

        protected double Exact(double x)
        {
            if (x == 0)
            {
                MessageBox.Show("Interval [x0, X] has a point of discontinuity");
                Application.Exit();
            }

            return Math.Pow(x, 4) + c * Math.Pow(x, 2);
        }

        //get x y values
        public void Calculate()
        {
            int n = (int)((X - x0) / 0.01);
            x = new double[n + 1];
            y = new double[n + 1];
            int co = 0;
            for (double i = x0; i <= X; i += 0.01)
            {
                x[co] = i;
                y[co] = Exact(i);
                co++;
            }
        }

        //F(x , y) = y prime
        protected double F(double x , double y)
        {
            if (x == 0)
            {
                MessageBox.Show("Interval [x0, X] has a point of discontinuity");
                Application.Exit();
            }

            return 2 * Math.Pow(x, 3) + 2 * y / x;            
        }
        
    }
}



