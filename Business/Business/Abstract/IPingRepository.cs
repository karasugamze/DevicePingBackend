using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPingRepository
    {
        List<PingDTO> GetBystatus(String Status);
        List<PingDTO> GetAll();
        
    }
}
