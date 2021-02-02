using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _color;
        public InMemoryColorDal()
        {
            _color = new List<Color>
            {
                new Color { ColorId=1, ColorName="White" },
                new Color { ColorId=2, ColorName="Yellow" },
                new Color { ColorId=3, ColorName="Red" },
                new Color { ColorId=4, ColorName="Blue" },
                new Color { ColorId=5, ColorName="Green" },
                new Color { ColorId=6, ColorName="Orange" },
                new Color { ColorId=7, ColorName="Purple" },
                new Color { ColorId=8, ColorName="Gray" },
                new Color { ColorId=9, ColorName="Black" },
            };
              
        }
        public List<Color> GetAll()
        {
            return _color;
        }
    }
}
