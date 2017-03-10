using System;

// می‌باشد Reference Type دقت داشته باشید که کلاس یک
// می‌گویند Local Variable متغیرهایی که در داخل یک تابع تعریف می‌کنیم اصطلاحا به آنها متغیر محلی یا
// می‌گویند field متغیرهایی که در داخل کلاس تعریف می‌شوند اصطلاحا به آنها
// هر کلاسی مسوول کار خودش می‌باشد
// توصیه می‌گردد که تمامی توابع داخل یک کلاس با یک فعل آغاز شده و حالت سوالی و یا امری داشته باشد
//.شده‌ای اشاره نماید new کرده، و یا به یک شیء از قبل new کار کنید، که یا آنرا Reference Type دقت داشته باشید، در صورتی می‌توانید با یک متغیر

//namespace LEARNING_CSHARP
//{
//	public class Person
//	{
//		public int Age;
//		public string FullName;
//	}

//	class Program
//	{
//		static void Main(string[] args)
//		{
//			//Person P;

//			//P.Age = 20;



//			//Person P;
//			//P = new Person();

//			//P.Age = 20;



//			//Person P = new Person();

//			//P.Age = 20;

//			System.Console.Write("Press [ENTER] To Exit...");
//			System.Console.ReadLine();
//		}
//	}
//}





//namespace LEARNING_CSHARP
//{
//	public class Person
//	{
//		public int Age;
//		public string FullName;
//	}

//	class Program
//	{
//		static void Main(string[] args)
//		{
//			Person P1 = new Person();

//			P1.Age = 20;
//			P1.FullName = "Ali Reza Alavi";

//			System.Console.WriteLine("Full Name: {0} - Age: {1}", P1.FullName, P1.Age);

//			Person P2 = new Person();

//			P2.Age = 30;
//			P2.FullName = "Sara Ahmadi";

//			System.Console.WriteLine("Full Name: {0} - Age: {1}", P2.FullName, P2.Age);

//			Person P3 = new Person();

//			P3.Age = 40;
//			P3.FullName = "Mohammad Ghaderi";

//			System.Console.WriteLine("Full Name: {0} - Age: {1}", P3.FullName, P3.Age);

//			Person P4 = new Person();

//			P4.Age = 50;
//			P4.FullName = "Reza Ghorji";

//			System.Console.WriteLine("Full Name: {0} - Age: {1}", P4.FullName, P4.Age);

//			System.Console.Write("Press [ENTER] To Exit...");
//			System.Console.ReadLine();
//		}
//	}
//}





//namespace LEARNING_CSHARP
//{
//	public class Person
//	{
//		public int Age;
//		public string FullName;
//	}

//	class Program
//	{
//		static void Main(string[] args)
//		{
//			Person P1 = new Person();

//			P1.Age = 20;
//			P1.FullName = "Ali Reza Alavi";

//			//System.Console.WriteLine("Full Name: {0} - Age: {1}", P1.FullName, P1.Age);
//			System.Console.WriteLine("I'm {0} and {1} years old.", P1.FullName, P1.Age);

//			Person P2 = new Person();

//			P2.Age = 30;
//			P2.FullName = "Sara Ahmadi";

//			//System.Console.WriteLine("Full Name: {0} - Age: {1}", P2.FullName, P2.Age);
//			System.Console.WriteLine("I'm {0} and {1} years old.", P2.FullName, P2.Age);

//			Person P3 = new Person();

//			P3.Age = 40;
//			P3.FullName = "Mohammad Ghaderi";

//			//System.Console.WriteLine("Full Name: {0} - Age: {1}", P3.FullName, P3.Age);
//			System.Console.WriteLine("I'm {0} and {1} years old.", P3.FullName, P3.Age);

//			Person P4 = new Person();

//			P4.Age = 50;
//			P4.FullName = "Reza Ghorji";

//			//System.Console.WriteLine("Full Name: {0} - Age: {1}", P4.FullName, P4.Age);
//			System.Console.WriteLine("I'm {0} and {1} years old.", P4.FullName, P4.Age);

//			System.Console.Write("Press [ENTER] To Exit...");
//			System.Console.ReadLine();
//		}
//	}
//}





//namespace LEARNING_CSHARP
//{
//	public class Person
//	{
//		public int Age;
//		public string FullName;

//		public void ShowInfo()
//		{
//			//System.Console.WriteLine("Full Name: {0} - Age: {1}", FullName, Age);
//			System.Console.WriteLine("I'm {0} and {1} years old.", FullName, Age);
//		}
//	}

//	class Program
//	{
//		static void Main(string[] args)
//		{
//			Person P1 = new Person();

//			P1.Age = 20;
//			P1.FullName = "Ali Reza Alavi";

//			P1.ShowInfo();

//			Person P2 = new Person();

//			P2.Age = 30;
//			P2.FullName = "Sara Ahmadi";

//			P2.ShowInfo();

//			Person P3 = new Person();

//			P3.Age = 40;
//			P3.FullName = "Mohammad Ghaderi";

//			P3.ShowInfo();

//			Person P4 = new Person();

//			P4.Age = 50;
//			P4.FullName = "Reza Ghorji";

//			P4.ShowInfo();

//			System.Console.Write("Press [ENTER] To Exit...");
//			System.Console.ReadLine();
//		}
//	}
//}
