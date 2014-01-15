using System;
using System.Collections.Generic;

namespace Quicksort
{
	public class Quicksort{

		public static List<int> quicksort(List<int> array){
			if (array.Count <= 1) {
				return array;
			} 
			else {
				Random rnd = new Random();
				int pivotIndex = rnd.Next (0, array.Count);
				List<int> pivot = new List<int>(); 
				pivot.Add(array[pivotIndex]);

				array.RemoveAt (pivotIndex);
				List<int> less = new List<int>();
				List<int> greater = new List<int> ();
				foreach (int n in array) {
					if (n <= pivot[0]) {
						less.Add (n);
					} else {
						greater.Add (n);
					}

				}
				List<int> inner_less = quicksort (less);
				List<int> inner_greater = quicksort (greater); 
				inner_less.AddRange (pivot);
				inner_less.AddRange (inner_greater);
				return inner_less; 

			}
		}

		public static void quicksortTest(){

			List<int> test = new List<int>();
			Random rnd = new Random();

			for (int i=0; i<100; i++){
				int nr = rnd.Next(1,101);
				test.Add (nr);
			}
			Console.WriteLine ("Input:");
			foreach (int n in test) {
				Console.Write ("{0} ", n);
			}
			Console.WriteLine (" ");
			Console.WriteLine (" ");
			Console.WriteLine ("Result:");

			List<int> result = quicksort (test);
			foreach (int n in result) {
				Console.Write ("{0} ", n);
			}
			Console.WriteLine (" ");

		}


		public static void Main(){
			
			quicksortTest ();

		}

	}
	
}

