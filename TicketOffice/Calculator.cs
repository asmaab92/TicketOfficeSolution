using System.Reflection.Metadata.Ecma335;

namespace TicketOffice
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            
            int age = 0;
            string place = null;
            
            
            int price = PriceSetter(age, place);
            TaxCalculator(price);
            
        }
        
        
        public static int PriceSetter(int age, string place)
        {
            Console.WriteLine("Enter your age, please ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If you want a seated ticket type 'seated', if you want a standing ticket type 'standing'");
            place = Console.ReadLine();

            int price = 0;

            if( age <= 11 && place == "seated")
            {
                price = 50;
                
                
            }
            else if ( age <= 11 && place == "standing")
            {
                price = 25;
            }
            else if (age >= 12 && age <= 64 && place == "seated")
            {
                price = 170;
            }
            else if (age >= 12 && age <= 64 && place == "standing")
            {
                price = 110;
            }
            else if (age >= 65 && place == "seated")
            {
                price = 100;
            }
            else if (age >= 65 && place == "standing")
            {
                price = 60;
            }
            Console.WriteLine("The price of the ticket is: " + price + "SEK");

            return price;
        }

        public static decimal TaxCalculator(int price)
        {
            
            decimal tax = Convert.ToDecimal(1 - 1 / 1.06) * price;
            Console.WriteLine("The paid tax is: " + tax + "SEK");
            return tax;
        }


        

    }
}
