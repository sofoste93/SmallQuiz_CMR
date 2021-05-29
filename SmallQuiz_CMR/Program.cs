using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallQuiz_CMR
{
	class Program
	{
		static void Main(string[] args)
		{
			string userInput = "";
			string cmrFirstPresident = "Amadou Ahidjo";
			string cmrCurrentPresident = "Paul Biya";
			string[] cmrTowns = { "Buea", "Kribi", "Limbe", "Douala", "Yaounde", "Bafoussam", "Bamenda", "Eseka", "Mbouda", "Edea" };

			// first serie
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("\n\t-- CAMEROON QUIZ --\n\n");
			
			Console.Write("- Who is the first president of cameroon?  ");
			userInput = Console.ReadLine();
			if (userInput != cmrFirstPresident) Console.WriteLine("\tWrong answer!\n");
			else Console.WriteLine("\tWell done!\n");

			Console.Write("- Who is the current president of cameroon?  ");
			userInput = Console.ReadLine();
			if (userInput != cmrCurrentPresident) Console.WriteLine("\tYou pretend not to know who's BIYA PAUL?\n");

			// new serie
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("\n\t-- RANDOM CMR TOWN --\n\n");

			Console.Write("Enter a number between 0 & 9: ");
			int choice = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("\n[" + cmrTowns[choice] + "] is a beautiful town!\n");

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("List of some towns in cameroon: \n");
			int sum = cmrTowns.Length;
			for(int i = 0; i < cmrTowns.Length; i++)
			{
				sum = sum + i;
				Console.WriteLine("\n\t["+i+"] => "+ cmrTowns[i]);
			}
			Console.ReadKey();

		}
	}
}
