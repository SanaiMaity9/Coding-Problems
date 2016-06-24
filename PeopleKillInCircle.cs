using System;
using System.Collections.Generic;

namespace Problems{
			public class Killer{
			public void kill(int start, List<int> peopleInCircle){
			LinkedList<string> linked = new LinkedList<string>();
			foreach (var people in linked) {
			 Console.WriteLine(people);				
			}
		}
	}
}
public class Demo{
	public  void Programstart(string[] arg)
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