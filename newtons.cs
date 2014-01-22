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

		public static void newtonTest(){
			Derivative d = new Derivative();
			Func<double, double> f = delegate(double x) { return x*x-3; };

			double xn = -2.2;
			double f_val;
			double d_val;
			int count = 0;

			//
			while (count < 50){
				f_val = f(xn);
				d_val = d.Dev(f,xn);
				xn = xn-(f_val/d_val);
				Console.WriteLine("X{0} = {1}",count+1,xn);
				count++;
			}
		}

		public static void Main(){
			newtonTest();

		}



	}
}