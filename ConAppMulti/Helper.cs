using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppMulti
{
	public class Helper
	{
		IList<Person> myPeople;

		public IList<Person> MyPeople 
		{
			get { return myPeople ;}
			set { value = myPeople; }
		}

		public Helper()
		{
			this.myPeople = new List<Person>();
		}

		
		public void CreatePerson()
		{
			DoWork();
			foreach (var item in this.MyPeople)
			{
				Console.WriteLine(item);
			}
		}
		private void DoWork()
		{
				Person p = new Person("Piotr", "Zelt");
				myPeople.Add(p);
		}
	}
}
