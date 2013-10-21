using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Data.Services;
using System.Runtime.Serialization;

namespace DeviceManagerService
{
    partial class DeviceDatabaseClassesDataContext
    {
        IList<DeviceBO> devices = new List<DeviceBO>();
        //IList<DeviceBO> Devices = new List<DeviceBO>();

    }
}
