using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle item = new Rectangle();
            int length = 0;
            int width = 0;
            int i = 0;
            string error = "";
            void changeLength(bool isnew = false)
            {
                i = 0;
                error = "length should be greater than 0 and should be an integer. Please enter a value again !";
                do
                {
                    Console.Write($"{(i == 0 ? "" : error)}");
                    Console.Write($"\nPlease enter the {(isnew ? "new ":"")}length: ");
                    int.TryParse(Console.ReadLine().Trim(), out length);
                    i = 1;
                } while (!(length > 0));
                item.SetNewLength(length);
            }

            void changeWidth(bool isnew = false)
            {
                i = 0;
                error = "width should be greater than 0 and should be an integer. Please enter a value again";
                do
                {
                    Console.Write($"{(i == 0 ? "" : error)}");
                    Console.Write("\nPlease enter the width: ");
                    int.TryParse(Console.ReadLine().Trim(), out width);
                    i = 1;
                } while (!(width > 0));
                item.SetNewWidth(width);
            }

            changeLength();
            changeWidth();

            int choice = 0;
            do
            {
                i = 0;
                error = "\nPlease enter a valid choice from below options !";
                do
                {
                    Console.Write($"{(i == 0 ? "" : error)}");
                    Console.WriteLine("\n\n--------- options ------------\n1. Get Rectangle Length \n2. Change Rectangle Length \n3. Get Rectangle Width \n4. Change Rectangle Width \n5. Get Rectangle Perimeter \n6. Get Rectangle Area \n7. Exit");
                    Console.Write("\nEnter an input from options above: ");
                    int.TryParse(Console.ReadLine().Trim(), out choice);
                    i = 1;
                } while (choice <= 0 || choice > 7);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Current Length = {item.GetCurrentLength()}");
                        break;
                    case 2:
                        changeLength(true);
                        break;
                    case 3:
                        Console.WriteLine($"Current Width = {item.GetCurrentWidth()}");
                        break;
                    case 4:
                        changeWidth(true);
                        break;
                    case 5:
                        Console.WriteLine($"Perimeter = {item.GetPerimeter()}");
                        break;
                    case 6:
                        Console.WriteLine($"Area = {item.GetArea()}");
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("SomeThing went wrong!");
                        break;
                }
            } while (choice != 7);
            Console.ReadKey();
        }
    }
}
