using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTOs;
using Domain.Entities;

namespace Business.Abstract
{
    public interface IDeviceRepository
    {
        List<deviceDTO> GetAll();
        deviceDTO GetByID(int ID);
        deviceDTO GetByName(string deviceName);
        
    }
}
