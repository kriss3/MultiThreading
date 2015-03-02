using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppMulti
{
	public class Person
	{
		private string fname;
		private string lname;
		private int age;

		public string FName { get { return fname; } set { value = fname; } }
		public string LName { get { return lname; } set { value = lname; } }
		public int Age { get { return age; } set { value = age; } }
		

		public Person(string fname, string lname)
		{
			this.fname = fname;
			this.lname = lname;
			
			Random rn = new Random();
			this.age = rn.Next(25, 75);
		}

		public override string ToString()
		{
			return String.Format("First Name: {0}\nLast Name: {1}\nAge: {2}",
				FName, LName, Age);
		}
	}
}
