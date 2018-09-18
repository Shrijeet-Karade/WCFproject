using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class HotelData
    {
        public List<HotelModel> data = new List<HotelModel>();
        public HotelData()
        {
            
            for (int i=1;i<5;i++)
            {
                HotelModel obj = new HotelModel();
                obj.id = i;
                obj.name = "Hotel " + i;
                obj.rating = i + 1;
                obj.address = "Area " + i;
                data.Add(obj);
            }

        }
    }
}
