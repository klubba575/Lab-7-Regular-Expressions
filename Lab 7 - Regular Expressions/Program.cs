using System;
using System.Text.RegularExpressions;

namespace Lab_7___Regular_Expressions
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter a valid name");
			string nameInput = Console.ReadLine();
			Console.WriteLine(NameValidation(nameInput));

			Console.WriteLine("Please enter a valid email");
			string emailInput = Console.ReadLine();
			Console.WriteLine(EmailValidation(emailInput));

			Console.WriteLine("Please enter a valid phone number");
			string phoneInput = Console.ReadLine();
			Console.WriteLine(PhoneNumberValidation(phoneInput));

			Console.WriteLine("Please enter a valid date");
			string dateInput = Console.ReadLine();
			Console.WriteLine(DateValidation(dateInput));

			Console.WriteLine("Please enter a valid html element");
			string htmlInput = Console.ReadLine();
			Console.WriteLine(HtmlValidation(htmlInput));


		}

		public static string NameValidation(string nameInput)
		{
			if(Regex.IsMatch(nameInput, @"^[A-Z]{1}[A-Za-z\s]{2,30}$"))
			{
				return "Valid Name Entered";
			}
			return "You did not enter a name!";
		}
		public static string EmailValidation(string emailInput)
		{
			if(Regex.IsMatch(emailInput, @"^[A-Za-z\d]{5,30}\@[A-z\d]{5,10}\.[A-z\d]{2,3}$"))
			{
				return "Thanks for entering your email.";
			}
			return "You did not enter a valid email address!";
		}
		public static string PhoneNumberValidation(string phoneInput)
		{
			if(Regex.IsMatch(phoneInput, @"\d{3}\-\d{3}\-\d{4}"))
			{
				return "Thanks for entering your phone number.";
			}
			return "You did not enter a valid phone number!";
		}
		public static string DateValidation(string dateInput)
		{
			if(Regex.IsMatch(dateInput, @"^\d{2}\/\d{2}\/\d{4}$"))
			{
				return "Thanks for entering a valid date.";
			}
			return "Please enter a valid DOB.";
		}
		public static string HtmlValidation(string htmlInput)
		{
			if(Regex.IsMatch(htmlInput, @"^\<[A-Za-z\d]{1,10}\>$"))
			{
				return "Thanks for entering your html term";
			}
			return "I do not think this is a valid Html term.";
		}
	}
}
