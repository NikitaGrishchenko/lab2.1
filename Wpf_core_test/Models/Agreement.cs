using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_core_test.Models
{
    public class Agreement
    {
        public int Id { get; set; } // первичный ключ
        public int Number{ get; set; } // номер
        public DateTime DateOpen { get; set; } // дата подписания
        public DateTime DateClose { get; set; } // дата закрытия
        public int PersonId { get; set; } // внешний ключ
        public int TypeId { get; set; } // внешний ключ 
        public int StatusId { get; set; } //внешний ключ


        public StatusAggrement StatusAggrement { get; set; } // навигационное свойство
        public TypeAggrement TypeAggrement { get; set; } // навигационное свойство
        public Person Person { get; set; } // навигационное свойство

    }
}
