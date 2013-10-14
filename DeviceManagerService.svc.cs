//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Data.Common.CommandTrees;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace DeviceManagerService
{
    [System.ServiceModel.ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class DeviceManagerService : DataService<DeviceDatabaseClassesDataContext>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
            config.UseVerboseErrors = true;
        }

        DeviceDatabaseClassesDataContext db = new DeviceDatabaseClassesDataContext();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [WebGet(UriTemplate = "?name='{name}'")]
        public IQueryable<Device> GetDevicesByName(string name)
        {
            IQueryable<Device> devices = from d in db.Devices
                                         where d.Name.Contains(name)
                                         select d;
            //var query = from cust in db.
            return devices;
        }

        [WebGet(UriTemplate = "?id={id}")]
        public IQueryable<Device> GetById(int id)
        {
            IQueryable<Device> x = from d in db.Devices
                                   where d.ID.Equals(id)
                                   select d;
            return x;
        }


        [WebGet(UriTemplate = "?type='{type}'")]
        public string RetrieveAll(string type, string criteria)
        {
            if (type == "Device")
            {
                //Dictionary<string, string> criteriaDic = new Dictionary<string, string>();
                //foreach (string param in criteria.Split(';'))
                //{
                //    //param.Split('=')
                //}
                List<DeviceBO> devices = new List<DeviceBO>();
                foreach (Device d in db.Devices)
                {
                    DeviceBO deviceBO = new DeviceBO();
                    deviceBO.ID = d.ID;
                    deviceBO.Name = d.Name;
                    deviceBO.PartNumber = d.PartNumber;
                    deviceBO.SerialNumber = d.SerialNumber;
                    deviceBO.FirmwareRevision = d.FirmwareRevision;
                    deviceBO.FIDString = d.FIDString;
                    deviceBO.Description = d.Description;

                    //deviceBO.Connection = new ConnectionBO();
                    //deviceBO.Connection.ATString = d.Connection.ATString;
                    //deviceBO.Connection.BaudRate = d.Connection.BaudRate;
                    //deviceBO.Connection.ConnectionType = d.Connection.ConnectionType.Name;
                    //deviceBO.Connection.DataBits = d.Connection.DataBits;
                    //deviceBO.Connection.DTR = d.Connection.DTR;
                    //deviceBO.Connection.ID = d.Connection.ID;
                    //deviceBO.Connection.IPAddress = d.Connection.IPAddress;
                    //deviceBO.Connection.Parity = d.Connection.Parity;
                    //deviceBO.Connection.PhoneNumber = d.Connection.PhoneNumber;
                    //deviceBO.Connection.PortNumber = d.Connection.PortNumber;
                    //deviceBO.Connection.RTS = d.Connection.RTS;
                    //deviceBO.Connection.RTSCTS = d.Connection.RTSCTS;
                    //deviceBO.Connection.StopBits = d.Connection.StopBits;
                    //deviceBO.Connection.XonXoff = d.Connection.XonXoff;

                    devices.Add(deviceBO);
                }
                //= (db.Devices.AsQueryable());
                //IQueryable<Device> devices = from d in db.Devices
                //where d.ID.Equals(id)
                //select d;
                //foreach(Device d in devices)
                //{
                //     IQueryable<DeviceType> devicetype = from dt in db.DeviceTypes
                //                                         where dt.ID == d.

                //}
                //IQueryable<DeviceType> devicetype 
                return "";
                //return devices.AsQueryable<DeviceBO>();
            }

            return null;

        }



        //[WebGet(UriTemplate = "?id={id}")]
        //public string DeleteDevice(int id)
        //{
        //    IQueryable<Device> device = from dev in db.Devices
        //                                where dev.ID.Equals(id)
        //                                select dev;
        //    IQueryable<Node> node = from n in db.Nodes
        //                            where n.DeviceID.Equals(id)
        //                            select n;
        //    IQueryable<DeviceDocument> devdoc = from n in db.DeviceDocuments
        //                                        where n.DeviceID.Equals(id)
        //                                        select n;
        //    if (node.Count() == 1 && device.Count() == 1)
        //    {
        //        db.Nodes.DeleteAllOnSubmit(node);
        //        db.DeviceDocuments.DeleteAllOnSubmit(devdoc);
        //        db.Devices.DeleteAllOnSubmit(device);
        //
        //        db.SubmitChanges();
        //        return "Successful";
        //    }
        //    return "Error";
        //}
    }
}
