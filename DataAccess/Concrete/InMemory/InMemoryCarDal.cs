using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; //Class içinde, metotların üstünde tanımlandığı için global değişkendir. Bu yüzden _ ile tanımlarız.
        public InMemoryCarDal() //Class ile aynı ada sahip olmalarından constructor olduğunu anlayabiliriz.
        {
            _cars = new List<Car> //Car listesi oluşturulur.
            {
                new Car{CarId=1, BrandId=1, ColorId=1, CarName="Renault Clio 1.5",ModelYear=2001, DailyPrice=200, Description="Ekonomik araç", BuyingOffice="Ankara Esenboğa Havalimanı",ReturnOffice="Ankara Söğütözü",BuyDate=new DateTime(2021,2,2),ReturnDate=new DateTime(2021,2,3) },
                new Car{CarId=2, BrandId=2, ColorId=3, CarName="Ford Focus 1.5",ModelYear=2010, DailyPrice=250, Description="Orta sınıf araç", BuyingOffice="İstanbul Ataşehir",ReturnOffice="İstanbul Ataşehir",BuyDate=new DateTime(2021,2,20),ReturnDate=new DateTime(2021,2,21) },
                new Car{CarId=3, BrandId=3, ColorId=5, CarName="Opel Insignia 1.6",ModelYear=2015, DailyPrice=360, Description="Orta sınıf araç", BuyingOffice="İzmir Alsancak",ReturnOffice="İzmir Adnan Menderes Havalimanı",BuyDate=new DateTime(2021,3,10),ReturnDate=new DateTime(2021,3,25) },
                new Car{CarId=5, BrandId=1, ColorId=1, CarName="BMW 320i 1.6",ModelYear=2019, DailyPrice=420, Description="Üst sınıf araç", BuyingOffice="Antalya Havalimanı",ReturnOffice="Antalya Havalimanı",BuyDate=new DateTime(2021,4,1),ReturnDate=new DateTime(2021,4,7) },

            };
            

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        }

        public List<Car> GetAll()
        {
            return _cars; //Veritabanını olduğu gibi gönderir.
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.BuyingOffice = car.BuyingOffice;
            carToUpdate.ReturnOffice = car.ReturnOffice;
            carToUpdate.BuyDate = car.BuyDate;
            carToUpdate.ReturnDate = car.ReturnDate;
        }
    }
}
