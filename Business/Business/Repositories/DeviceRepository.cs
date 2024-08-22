using Business.Abstract;
using Business.Context;
using Business.Mappings;
using Domain.DTOs;
using Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {


        public List<deviceDTO> GetAll()
        {
            using (var context = new AppDBContext())
            {
                var data = context.Device.ToList();

                var mdevice = new MapDevice().mapDeviceList(data);
                return mdevice;
            }

            //We read the file we added to the project
            //string jsondata = File.ReadAllText("data.json");
            //We matched the file we read with entity.
            //List<Device> devices = JsonConvert.DeserializeObject<List<Device>>(jsondata);

        }

        public deviceDTO GetByID(int ID)
        {
            using (var context = new AppDBContext())
            {
                var data = context.Device.Where(x => x.pingID == ID).FirstOrDefault();
                var mdevice = new MapDevice().mapDevicesingle(data);

                return mdevice;

            }


            //string jsondata = File.ReadAllText("data.json");
            //List<Device> devices1 = JsonConvert.DeserializeObject<List<Device>>(jsondata);

            //var model = devices1.Where(x => x.pingID == x.pingID).FirstOrDefault();
            //return model;
        }

        public deviceDTO GetByName(string deviceName)
        {
            using (var context = new AppDBContext())
            {
                var data =context.Device.Where(x=>x.cihazAdi.Contains(deviceName)).FirstOrDefault();
                var mdevice = new MapDevice().mapDevicesingle(data);
                return mdevice; 
            }



            //string jsondata = File.ReadAllText("data.json");
            //List<deviceDTO> devicesName = JsonConvert.DeserializeObject<List<deviceDTO>>(jsondata);

            //var dtoModel1 = new MapDevice().mapDeviceList(deviceName);

            //return dtoModel1;

        }
    }

}
