using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class DemoServices : IHotelFunctions
    {
        public List<HotelModel> GetAllhotels()
        {
            HotelData obj = new HotelData();
            return obj.data;
        }
        public List<HotelModel> GetHotelByID(int id)
        {
            HotelData obj = new HotelData();
            List<HotelModel> newData = obj.data;
            return newData;
        }
    }
}
