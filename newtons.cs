using System;

namespace Newtons{

	public class Newtons{
	
		public class Derivative{

			double h = 10e-6;

			//First Derivative Five-Point-Rule
			public double Dev(Func<double,double> f, double x){
				double h2 = h*2;
    			return (f(x-h2) - 8*f(x-h) + 8*f(x+h) - f(x+h2)) / (h2*6);
			}

		}

		public class Newton : Derivative{
			Func<double,double> f;
			double xn = 2.2;
			double f_val;
			double d_val;
			int maxn = 100;
			int count = 1;
			double min_error = 10e-7;
			double eps = 1.0;
			double y;

			public Newton(Func<double,double> function, double error, int max_iter){
				min_error = error;
				f = function;
				maxn = max_iter;
			} 

			public void Aproximate(){

				while (eps >= min_error && count <= maxn){
				f_val = f(xn);
				d_val = Dev(f,xn);
				y = xn-(f_val/d_val);
				eps = Math.Abs(y-xn);
				xn = xn-(f_val/d_val);
				Console.WriteLine("X{0} = {1}",count,xn);
				count++;
			}
		}


		}

		public static void Main(){
			Func<double, double> f = delegate(double x) { return x*x-5; };
			Newton newton = new Newton(f,10e-7,100);
			newton.Aproximate();

		}



	}
}