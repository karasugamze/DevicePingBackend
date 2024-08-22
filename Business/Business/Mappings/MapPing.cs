using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mappings
{
    public class MapPing
    {
        public PingDTO mapsingleping(Ping entity)
        {
            PingDTO dto=new PingDTO();
            dto.Status = entity.status;    // ? "Up": "Down";
            dto.ID = entity.pingID;
            dto.time = entity.zaman;


            return dto;
            
        }

        public List<PingDTO> mappinglist(List<Ping> entities)
        {
            List<PingDTO> list1 = new List<PingDTO>();
            
            foreach (var entity in entities) {
                PingDTO dto = new PingDTO();
                dto.time = entity.zaman;
                dto.ID=entity.pingID;
                dto.Status = entity.status;     // ? "Up": "Down";

                list1.Add(dto);
               
            }
            return list1;

            //return list1.OrderByDescending(x =>x.ID).Take(10).ToList();
        }
    }
}
