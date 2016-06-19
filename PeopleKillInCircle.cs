using System;
using System.Collections.Generic;

namespace Problems{
			public class Killer{
			public void kill(int start, List<int> peopleInCircle){
			foreach (var people in peopleInCircle) {
				Console.WriteLine ("last person alive = " + people);			
			}
		}
	}
}
public class Demo{
	public  void Main(string[] arg)
	{
		Problems.Killer killer = new Problems.Killer ();

		int startPostion = 3;
		List<int> peopleInCircle = new List<int>();
		var numberOfPeople = 10;
		for(int i=0; i < numberOfPeople; i++){
			peopleInCircle.Add(i);
		}
			
		killer.kill (startPostion, peopleInCircle);
	}


}