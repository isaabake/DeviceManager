using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DeviceManagerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DataService : IDataService
    {
        DeviceDatabaseClassesDataContext db = new DeviceDatabaseClassesDataContext();
       
        public List<Device> GetDevicesByName(string name)
        {
            var x =
                from d in db.Device
                where d.Name.Contains(name)
                select d;
            //var query = from cust in db.
            return x.ToList();
        }

        public List<Device> GetDevicesById(int id)
        {
            var x = from d in db.Device
                    where d.ID.Equals(id)
                    select d;
            return x.ToList();
        }

        public List<Device> GetDevicesByParent(int pid)
        {
            var x = from d in db.Device
                    where d.ID.Equals(pid)
                    select d;
            return x.ToList();
        }
    }
}
