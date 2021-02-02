using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        //Class'lar çıplak kalmaz !
        public int CarId { get; set; }
        public int CarBrandId { get; set; }
        public int CarColorId { get; set; }
        public short CarModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string CarDescription { get; set; }
    }
}
