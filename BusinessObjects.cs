using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeviceManagerService
{

    public class NodeBO
    {

    }

    public class DeviceBO
    {
        public int ID { set; get; }
        public string Name { get; set; }
        public string DeviceType { set; get; }
        public int ConnectionID { set; get; }
        public string Description { set; get; }
        public string SerialNumber { set; get; }
        public string FirmwareRevision { set; get; }
        public string PartNumber { set; get; }
        public string FIDString { set; get; }

        /// <summary>
        /// Returns the device as a list of DataSet
        /// </summary>
        /// <returns>The device in DataSet form</returns>
        public List<DataSet> AsDataSet()
        {
            List<DataSet> deviceData = new List<DataSet>();

            deviceData.Add(new DataSet { Name = "ID", Type = "int", Value = this.ID.ToString() });
            deviceData.Add(new DataSet { Name = "Name", Type = "string", Value = this.Name });
            deviceData.Add(new DataSet { Name = "DeviceType", Type = "string", Value = this.DeviceType });
            deviceData.Add(new DataSet { Name = "ConnectionID", Type = "int", Value = this.ConnectionID.ToString() });
            deviceData.Add(new DataSet { Name = "Description", Type = "string", Value = this.Description });
            deviceData.Add(new DataSet { Name = "SerialNumber", Type = "string", Value = this.SerialNumber });
            deviceData.Add(new DataSet { Name = "FirmwareRevision", Type = "string", Value = this.FirmwareRevision });
            deviceData.Add(new DataSet { Name = "PartNumber", Type = "string", Value = this.PartNumber });
            deviceData.Add(new DataSet { Name = "FIDString", Type = "string", Value = this.FIDString });

            return deviceData;
        }
    }
    public class ConnectionBO
    {
        public int ID { set; get; }
        public int? BaudRate { set; get; }
        public int? DataBits { set; get; }
        public int? StopBits { set; get; }
        public string Parity { set; get; }
        public bool? RTSCTS { set; get; }
        public bool? DTR { set; get; }
        public bool? RTS { set; get; }
        public bool? XonXoff { set; get; }
        public string PhoneNumber { set; get; }
        public string ATString { set; get; }
        public string IPAddress { set; get; }
        public int? PortNumber { set; get; }
        public string ConnectionType { set; get; }
    }

}

