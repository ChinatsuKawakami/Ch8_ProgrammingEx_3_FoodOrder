using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// virsion 0.0.2 Added Another answer
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

/*********************************************************************************************************
 
public static void Main(string[] args)
        {
       

         
          Console.Write("Enter Item Number or description: ");
          //int itemNumber = Convert.ToInt32(Console.ReadLine());
          //string description = Convert.ToString(Console.ReadLine());
           

          string x = Console.ReadLine();

          int itemNum;


          if (int.TryParse(x, out itemNum))
              Console.WriteLine(GetDetails(itemNum));
          else
              Console.WriteLine(GetDetails(x));
           /*if (x == "20" || x == "23" || x=="25"|| x=="31")
           {
             int itemNumber = int.Parse(x);
               Console.WriteLine(GetDetails(itemNumber));

           }// close if
           else if (x == "Enchilada" || x == "Burrito" || x == "Taco" || x == "Tostada")
           {
               string description = x;
            Console.WriteLine(GetDetails(description));

           }//close else if
           else
           {
               Console.WriteLine("Please Enter Valid ItemNumber or Description!");
           }
 * 
 * }
          */
           
          



        /*

        //input interger version
        public static string GetDetails(int itemNumber)
        {   
            
            //double price;
            //string description;
            string answer;
            string message;
            
                //switch
             switch (itemNumber)
           {
              
                 case 20:
                    // description = "Enchilada";
                    // price = 2.95;
                     answer = "Description:Enchilada, Price:2.95";
                     break;

                 case 23:
                   //description = "Burrito";
                  // price = 1.95;
                  answer = "Description: Burrito, Price:1.95";
                 // answer = String.Format("Item Number:{0},Description:{1}, Price:{2}", itemNumber,description, price);
                     break;

                 case 25:
                    // description = "Taco";
                    // price = 2.25;
                    answer = " Description:Taco, Price:2.25";
                    // answer = String.Format("Item Number:{0},Description:{1}, Price:{2}", itemNumber,description, price);
                     break;

                 case 31:
                    // description = "Tostada";
                    // price = 3.10;
                    answer = "Description:Tostada, Price: 3.10" ;
                   // answer = String.Format("Item Number:{0},Description:{1}, Price:{2}", itemNumber,description, price);
                     break;
                   
                 default :
                     answer = "Please Enter Valid ItemNumber or Description!";
                     break;

            }//close switch
            
            message =String.Format(answer);
            return message;
             
        }//close  GetDetails() method
         public static string GetDetails(string description)
        {
          
           // int itemNumber;
           // double price;
            string answer;
           // string message;
   
                  switch(description)
                  {
                      case "Enchilada":
                        //  itemNumber = 20;
                        //  price = 2.95;
                          answer = "Item Number:20, Price:2.95";
                          break;
                      case "Burrito":
                         // itemNumber = 23;
                         // price = 1.95;
                          answer = "Item Number:23, Price:1.95";
                           break;
                      case "Taco":
                         // itemNumber = 25;
                         //  price = 2.25;
                           answer = "Item Number:25, Price:2.25";
                           break;
                      case "Tostada":
                         //  itemNumber = 31;
                        //price = 3.10;
                           answer = "Item Number:31, Price:3.10";
                           break;
                     default:
                           answer = "Please Enter Valid ItemNumber or Description!";
                            break;
                  }// close switch
             //     message = String.Format(answer);
                  return answer;
                       
        }//close GetDetails Method
         
        }
    }


 
 */
