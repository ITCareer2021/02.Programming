﻿using System;

namespace ConsoleApp7
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstName = Console.ReadLine();
			string lastName = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			Console.WriteLine("Hello, {0} {1}. You are {2} years old.", firstName, lastName, age);
		}

	}
}