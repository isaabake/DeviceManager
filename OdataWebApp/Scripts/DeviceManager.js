﻿

/*//////////////////////////////////////////////////////////////////////////////////////
////// Autogenerated by JaySvcUtil.exe http://JayData.org for more info        /////////
//////                             oData V1.1                                    /////////
//////////////////////////////////////////////////////////////////////////////////////*/
(function(global, $data, undefined) {

    
  $data.Entity.extend('DeviceManagerService.Connection', {
     'ID': { 'key':true,'type':'Edm.Int32','nullable':false,'required':true },
     'ConnectionTypeID': { 'type':'Edm.Int32','nullable':false,'required':true },
     'BaudRate': { 'type':'Edm.Int32' },
     'DataBits': { 'type':'Edm.Int32' },
     'StopBits': { 'type':'Edm.Int32' },
     'Parity': { 'type':'Edm.String' },
     'RTSCTS': { 'type':'Edm.Boolean' },
     'DTR': { 'type':'Edm.Boolean' },
     'RTS': { 'type':'Edm.Boolean' },
     'XonXoff': { 'type':'Edm.Boolean' },
     'PhoneNumber': { 'type':'Edm.String' },
     'ATString': { 'type':'Edm.String' },
     'IPAddress': { 'type':'Edm.String' },
     'PortNumber': { 'type':'Edm.Int32' },
     'Devices': { 'type':'Array','elementType':'DeviceManagerService.Device','inverseProperty':'$$unbound' },
     'ConnectionType': { 'type':'DeviceManagerService.ConnectionType','inverseProperty':'$$unbound' }
  });

  $data.Entity.extend('DeviceManagerService.Node', {
     'ID': { 'key':true,'type':'Edm.Int32','nullable':false,'required':true },
     'ParentID': { 'type':'Edm.Int32' },
     'DeviceID': { 'type':'Edm.Int32' },
     'FolderID': { 'type':'Edm.Int32' },
     'Nodes': { 'type':'Array','elementType':'DeviceManagerService.Node','inverseProperty':'$$unbound' },
     'Node1': { 'type':'DeviceManagerService.Node','inverseProperty':'$$unbound' },
     'Device': { 'type':'DeviceManagerService.Device','inverseProperty':'$$unbound' },
     'Folder': { 'type':'DeviceManagerService.Folder','inverseProperty':'$$unbound' }
  });

  $data.Entity.extend('DeviceManagerService.ConnectionType', {
     'ID': { 'key':true,'type':'Edm.Int32','nullable':false,'required':true },
     'Name': { 'type':'Edm.String' },
     'Connections': { 'type':'Array','elementType':'DeviceManagerService.Connection','inverseProperty':'$$unbound' }
  });

  $data.Entity.extend('DeviceManagerService.Device', {
     'ID': { 'key':true,'type':'Edm.Int32','nullable':false,'required':true },
     'Name': { 'type':'Edm.String' },
     'DeviceTypeID': { 'type':'Edm.Int32','nullable':false,'required':true },
     'ConnectionID': { 'type':'Edm.Int32' },
     'Description': { 'type':'Edm.String' },
     'SerialNumber': { 'type':'Edm.String' },
     'FirmwareRevision': { 'type':'Edm.String' },
     'PartNumber': { 'type':'Edm.String' },
     'FIDString': { 'type':'Edm.String' },
     'GlobalDeviceID': { 'type':'Edm.String' },
     'Nodes': { 'type':'Array','elementType':'DeviceManagerService.Node','inverseProperty':'$$unbound' },
     'DeviceDocuments': { 'type':'Array','elementType':'DeviceManagerService.DeviceDocument','inverseProperty':'$$unbound' },
     'Connection': { 'type':'DeviceManagerService.Connection','inverseProperty':'$$unbound' },
     'DeviceType': { 'type':'DeviceManagerService.DeviceType','inverseProperty':'$$unbound' }
  });

  $data.Entity.extend('DeviceManagerService.DeviceDocument', {
     'ID': { 'key':true,'type':'Edm.Int32','nullable':false,'required':true },
     'Name': { 'type':'Edm.String' },
     'Data': { 'type':'Edm.Binary' },
     'DeviceID': { 'type':'Edm.Int32','nullable':false,'required':true },
     'Description': { 'type':'Edm.String' },
     'Device': { 'type':'DeviceManagerService.Device','inverseProperty':'$$unbound' }
  });

  $data.Entity.extend('DeviceManagerService.DeviceType', {
     'ID': { 'key':true,'type':'Edm.Int32','nullable':false,'required':true },
     'Name': { 'type':'Edm.String' },
     'CanHaveChildren': { 'type':'Edm.Boolean','nullable':false,'required':true },
     'Devices': { 'type':'Array','elementType':'DeviceManagerService.Device','inverseProperty':'$$unbound' }
  });

  $data.Entity.extend('DeviceManagerService.Folder', {
     'ID': { 'key':true,'type':'Edm.Int32','nullable':false,'required':true },
     'Name': { 'type':'Edm.String' },
     'Nodes': { 'type':'Array','elementType':'DeviceManagerService.Node','inverseProperty':'$$unbound' },
     'FolderDocuments': { 'type':'Array','elementType':'DeviceManagerService.FolderDocument','inverseProperty':'$$unbound' }
  });

  $data.Entity.extend('DeviceManagerService.FolderDocument', {
     'ID': { 'key':true,'type':'Edm.Int32','nullable':false,'required':true },
     'Name': { 'type':'Edm.String' },
     'Data': { 'type':'Edm.Binary' },
     'FolderID': { 'type':'Edm.Int32','nullable':false,'required':true },
     'Description': { 'type':'Edm.String' },
     'Folder': { 'type':'DeviceManagerService.Folder','inverseProperty':'$$unbound' }
  });

  $data.EntityContext.extend('DeviceManagerService.DeviceDatabaseClassesDataContext', {
     'Connections': { type: $data.EntitySet, elementType: DeviceManagerService.Connection},
     'Nodes': { type: $data.EntitySet, elementType: DeviceManagerService.Node},
     'ConnectionTypes': { type: $data.EntitySet, elementType: DeviceManagerService.ConnectionType},
     'Devices': { type: $data.EntitySet, elementType: DeviceManagerService.Device},
     'DeviceDocuments': { type: $data.EntitySet, elementType: DeviceManagerService.DeviceDocument},
     'DeviceTypes': { type: $data.EntitySet, elementType: DeviceManagerService.DeviceType},
     'Folders': { type: $data.EntitySet, elementType: DeviceManagerService.Folder},
     'FolderDocuments': { type: $data.EntitySet, elementType: DeviceManagerService.FolderDocument},
     'GetDevicesByName': { type: $data.ServiceOperation, returnType: $data.Queryable, elementType: 'DeviceManagerService.Device', 'EntitySet': 'Devices', method: 'GET', params: [{ name: 'name', type: 'Edm.String' }] },
     'GetById': { type: $data.ServiceOperation, returnType: $data.Queryable, elementType: 'DeviceManagerService.Device', 'EntitySet': 'Devices', method: 'GET', params: [{ name: 'id', type: 'Edm.Int32' }] },
     'GetByPid': { type: $data.ServiceOperation, returnType: $data.Queryable, elementType: 'DeviceManagerService.Device', 'EntitySet': 'Devices', method: 'GET', params: [{ name: 'pid', type: 'Edm.Int32' }] },
     'RetrieveAll': { type: $data.ServiceOperation, returnType: 'Edm.String', method: 'GET', params: [{ name: 'type', type: 'Edm.String' }, { name: 'criteria', type: 'Edm.String' }] }
  });

  $data.generatedContexts = $data.generatedContexts || [];
  $data.generatedContexts.push(DeviceManagerService.DeviceDatabaseClassesDataContext);
  
      
})(window, $data);
      
    