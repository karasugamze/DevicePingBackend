using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mappings
{
    public class MapDevice
    {
        public deviceDTO mapDevicesingle(Device entity)
        {
            deviceDTO dto =new deviceDTO();
            dto.ID = entity.pingID;
            dto.deviceName = entity.cihazAdi;

            return dto;
        }

        public List<deviceDTO> mapDeviceList(List<Device> entities)
        {

            List<deviceDTO> list1 = new List<deviceDTO>();

            foreach (Device entity in entities)
            {
                deviceDTO dto = new deviceDTO();
                dto.ID = entity.pingID;
                dto.deviceName = entity.cihazAdi;

                list1.Add(dto);
            }
            return list1;
        }
    }
}
