using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Domain.Enum;

namespace LegalPlatform.Infrastructure.Domain.DTOs.NewFolder
{
    public class MakeAppointmentDTO
    {
        public string LawerName { set; get; }
        public string ClientName { set; get; }
        public DateTime Date { set; get; }
        public string Description { set; get; }
    }
}
