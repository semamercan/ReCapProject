using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand { BrandId=1, BrandName="Renault Clio"},
                new Brand { BrandId=2, BrandName="Ford Focus"},
                new Brand { BrandId=3, BrandName="Opel Insignia"},
                new Brand { BrandId=4, BrandName="BMW 320i"}

            };

        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

    }
}
