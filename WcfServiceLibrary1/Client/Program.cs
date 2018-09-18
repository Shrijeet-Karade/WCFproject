using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to Get all hotel Details");
            Console.WriteLine("Enter 2 to get hotel by id (Id between 1-5)");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    HotelFunctionsClient hotel = new HotelFunctionsClient("BasicHttpBinding_IHotelFunctions");
                    List<HotelModel> myList = hotel.GetAllhotels().ToList();
                    foreach (var x in myList)
                    {
                        Console.WriteLine("Hotel Id" + x.id);
                        Console.WriteLine("Hotel Name" + x.name);
                        Console.WriteLine("Hotel Address" + x.address);
                        Console.WriteLine("HotelRating " + x.rating);
                        Console.WriteLine();
                    }
                    
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Enter the Id of hotel you want to search");
                    int IDD = Convert.ToInt32(Console.ReadLine());
                    HotelFunctionsClient hotel2 = new HotelFunctionsClient("BasicHttpBinding_IHotelFunctions");
                    List<HotelModel> myNewList = hotel2.GetAllhotels().ToList();
                    foreach (var x in myNewList)
                    {
                        if (x.id == IDD)
                        {
                            Console.WriteLine("Hotel Id" + x.id);
                            Console.WriteLine("Hotel Name" + x.name);
                            Console.WriteLine("Hotel Address" + x.address);
                            Console.WriteLine("HotelRating " + x.rating);
                            Console.WriteLine();
                        }
                    }
                   
                    Console.ReadKey();
                    break;

                default: break;

            }
        }
    }

}

