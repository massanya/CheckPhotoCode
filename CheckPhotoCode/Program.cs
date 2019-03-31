using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Lesson_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Здравствуйте, меня зовут Василиса. Укажите список документов.");

			//var documents = new string[1];
			//List<string> ls = new List<string>();
			//ls.Add("Hello");
			//string[] t = new string[3];

			var documents = Console.ReadLine();
			{
				if (documents.Contains("photo"))
				{
					Console.WriteLine("Фотография старше 3-х месяцев?(y/n)");
					if (Console.ReadLine() == "n")
					{
						Console.WriteLine("Использовалась ли эта фотография на паспорт?(y/n)");
						if (Console.ReadLine() == "y")
						{
							Console.WriteLine("Фотография вклеена?(y/n)");
							if (Console.ReadLine() == "n")
							{
								Console.WriteLine("Вклейте фотографию");
								Console.ReadLine();
							}
							else
							{
								Console.WriteLine("Проходите на оплату");
								Console.ReadLine();
							}
						}
						else
						{
							Console.WriteLine("Эта фотография не должна быть использована для паспорта.Сделайте фото");
							Console.ReadLine();
						}
					}
					else
					{
						Console.WriteLine("Фотография должна быть не старше 3-х месяцев.Сделайте фото");
						Console.ReadLine();
					}
				}
				else
				{
					Console.WriteLine("У вас нет фотографии.Сделайте фото");
					Console.ReadLine();
				}


			}
		}
	}
}
