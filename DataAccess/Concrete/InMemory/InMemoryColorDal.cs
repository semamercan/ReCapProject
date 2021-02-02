using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>
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

        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color colorToDelete = _colors.SingleOrDefault(co => co.ColorId == color.ColorId);
        }

        public List<Color> GetAll()
        {
            return _colors;
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _colors.SingleOrDefault(co => co.ColorId == color.ColorId);
            colorToUpdate.ColorId = color.ColorId;
            colorToUpdate.ColorName = color.ColorName;
        }
    }
}
