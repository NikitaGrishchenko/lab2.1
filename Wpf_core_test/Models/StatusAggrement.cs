using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_core_test.Models
{
    public class StatusAggrement
    {
        public int Id { get; set; }
        public string Status { get; set; } // статус


        public List<Agreement> Agreement { get; set; } // навигационное свойство
    }
}
