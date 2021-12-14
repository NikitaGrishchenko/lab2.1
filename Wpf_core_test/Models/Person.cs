using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_core_test.Models
{
    public class Person
    {
        public int Id { get; set; }
        public int Inn { get; set; } // инн
        public string Shifer { get; set; } // шифр клиента
        public string Type { get; set; } // тип клиента
        public DateTime Date { get; set; } // дата регистрации пользователя

        public List<Agreement> Agreement { get; set; } // навигационное свойство
    }
}
