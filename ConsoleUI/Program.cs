using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

           
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Name :" + car.CarName);
                Console.WriteLine("Buying Office :" + car.BuyingOffice);
                Console.WriteLine("Return Office :" + car.ReturnOffice);
                Console.WriteLine("Buy Date : " + car.BuyDate);
                Console.WriteLine("Return Date : " + car.ReturnDate);
                Console.WriteLine("Rental Price :" + ((car.ReturnDate-car.BuyDate).TotalDays)*car.DailyPrice);  //Kiralama ve iade etme tarihi arasındaki gün farkını günlük kiralama fiyatı ile çarparız.
                Console.WriteLine();

            }
        }
    }
}
