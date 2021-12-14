using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_core_test.Models
{
    public class TypeAggrement
    {
        public int Id { get; set; }
        public string Type { get; set; } // тип соглашения
   

        public List<Agreement> Agreement { get; set; } // навигационное свойство
    }
}
