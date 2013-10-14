using System.Collections.Generic;
using System.Data.Services;

namespace DeviceManagerService
{
    partial class DeviceDatabaseClassesDataContext
    {
        IList<DeviceBO> devices = new List<DeviceBO>();
        //IList<DeviceBO> Devices = new List<DeviceBO>();

    }
    public class DeviceBO
    {
        public int ID;
        public string Name;
        public string DeviceType;
        //public ConnectionBO Connection;
        public string Description;
        public string SerialNumber;
        public string FirmwareRevision;
        public string PartNumber;
        public string FIDString;
        //public EntitySet<DeviceDocument> _DeviceDocuments;
    }
    public class ConnectionBO
    {
        public int ID;
        public int? BaudRate;
        public int? DataBits;
        public int? StopBits;
        public string Parity;
        public bool? RTSCTS;
        public bool? DTR;
        public bool? RTS;
        public bool? XonXoff;
        public string PhoneNumber;
        public string ATString;
        public string IPAddress;
        public int? PortNumber;
        public string ConnectionType;
    }
}
