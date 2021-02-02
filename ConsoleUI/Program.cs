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
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            ColorManager colorManager = new ColorManager(new InMemoryColorDal());
            

            Console.WriteLine("***List of All Cars***");
            foreach (var brand in brandManager.GetAll())
            {
                
                Console.WriteLine(brand.BrandId + " : " + brand.BrandName);
            }

            Console.WriteLine("\n***List of All Colors***");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + " : " + color.ColorName);
            }

            Console.WriteLine("\n***Rented Cars and Informations***");
            foreach (var car in carManager.GetAll())
            {
                
                Console.WriteLine("Car Brand Id :" + car.BrandId);
                Console.WriteLine("Car Color Id :" + car.ColorId);
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
