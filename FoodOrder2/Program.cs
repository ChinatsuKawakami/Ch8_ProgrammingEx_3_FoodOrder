using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// virsion 0.0.1 initialize commit
namespace FoodOrder2
{
    class Program
    {
        static void Main(string[] args)
        {
            int item;
            //string x;
           string x = Console.ReadLine();

            Console.WriteLine("Enter Your item Number or Description of the item");
            
            if(int.TryParse(x,out item))
            {
                Console.WriteLine(GetDetails(item)); // don't forget static
            }
            else
            {
                Console.WriteLine(GetDetails(x)); 
            }
           
        }

        private static string GetDetails(int item)
        {
            string answer;
            
            switch (item)
            {
                case 20:
                    answer = "Description: Enchilada, Price: 2.95";
                    break;
                case 23:
                    answer ="Description: Burrito, Price: 1.95";
                    break;
                case 25:
                    answer ="Description: Taco, Price: 2.25";
                    break;
                case 31:
                    answer = "Description: Tostaba, Price: 3.10";
                    break;   
                default:
                    answer = "Invalid";
                    break;
            }
            return answer;
        }
        private static string GetDetails(string description)
        {
            string answer;
         //   string message;
            switch (description)
            {
                case "Enchilada":
                    answer ="Item Number: 20, Price: 2.95";
                    break;
                case "Burrito":
                    answer = "Item Number: 23, Price: 1.95";
                    break;
                case "Taco":
                    answer = "Item Number: 25, Price: 2.25";
                    break;
                case "Tostada":
                    answer ="Item Number: 31, Price: 3.10";
                    break;
                default:
                    answer = "Invalid";
                    break;

            }
              // message=String.Format(answer);
               return answer;
        }
    }
}
