using System;
using System.Collections.Generic;

namespace Mergesort{
	
	public class Mergesort{

		public static List<int> mergesort(List<int> list){

			if (list.Count <= 1 ){
				return list;
			}
			else{
				List<int> left = new List<int>();
				List<int> right = new List<int>();
				int middle_index = list.Count/2;

				for (int i=0; i<middle_index; i++){
					left.Add(list[i]);
				}
				for (int i=middle_index; i<list.Count; i++){
					right.Add(list[i]);
				}
				left = mergesort(left);
				right = mergesort(right);
				List<int> result = merge(left,right);
				return result;
			}
		}

		public static List<int> merge(List<int> left, List<int> right){
			List<int> result = new List<int>();
			while (left.Count > 0 || right.Count >0){
				if (left.Count > 0 && right.Count > 0){
					if (left[0] <= right[0]){
						result.Add(left[0]);
						left.RemoveAt(0);
					}
					else{
						result.Add(right[0]);
						right.RemoveAt(0);
					}
				}
				else if (left.Count > 0){
					result.Add(left[0]);
					left.RemoveAt(0);
				}
				else if (right.Count > 0){
					result.Add(right[0]);
					right.RemoveAt(0);
				}
			}
			return result;

		}


		

		public static void mergesortTest(){

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

			List<int> result = mergesort(test);
			foreach (int n in result) {
				Console.Write ("{0} ", n);
			}
			Console.WriteLine (" ");
		}

		public static void Main(){
			mergesortTest();
		}

	}
}