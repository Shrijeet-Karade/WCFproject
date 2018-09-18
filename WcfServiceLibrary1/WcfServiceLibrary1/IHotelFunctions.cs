using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace Demo
{
    [ServiceContract]
    interface IHotelFunctions
    {
        [OperationContract]
        List<HotelModel>GetAllhotels();

        [OperationContract]
        List<HotelModel> GetHotelByID(int id);
    }
}
