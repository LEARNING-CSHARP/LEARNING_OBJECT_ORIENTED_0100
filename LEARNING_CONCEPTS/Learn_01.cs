﻿using System;

// می‌باشد Reference Type دقت داشته باشید که کلاس یک
// می‌گویند Local Variable متغیرهایی که در داخل یک تابع تعریف می‌کنیم اصطلاحا به آنها متغیر محلی یا
// می‌گویند field متغیرهایی که در داخل کلاس تعریف می‌شوند اصطلاحا به آنها
// هر کلاسی مسوول کار خودش می‌باشد
// توصیه می‌گردد که تمامی توابع داخل یک کلاس با یک فعل آغاز شده و حالت سوالی و یا امری داشته باشد
//.شده‌ای اشاره نماید new کرده، و یا به یک شیء از قبل new کار کنید، که یا آنرا Reference Type دقت داشته باشید، در صورتی می‌توانید با یک متغیر

namespace LEARNING_CSHARP_Learn_01
{
	public class Person
	{
		public int Age;
		public string FullName;
	}

	class Program
	{
		static void Main(string[] args)
		{
			//Person P;

			//P.Age = 20;



			//Person P;
			//P = new Person();

			//P.Age = 20;



			//Person P = new Person();

			//P.Age = 20;

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
