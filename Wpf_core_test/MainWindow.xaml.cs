using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf_core_test.Models;

namespace Wpf_core_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }
        private void Initdb()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта Person
                Person pers1 = new Person { Inn = 24352345, Shifer = "sef3w4fwfgbjfjfbghver", Type = "Обычный", Date = new DateTime(2000, 3, 1, 7, 0, 0) };
                Person pers2 = new Person { Inn = 23444446, Shifer = "sef3fhbfthjw4fwver", Type = "Обычный", Date = new DateTime(2008, 3, 3, 7, 0, 0) };
                Person pers3 = new Person { Inn = 67856777, Shifer = "sef3w4bjhhbjfjffwver", Type = "Обычный", Date = new DateTime(2011, 3, 1, 7, 0, 0) };

                db.Persons.Add(pers1);
                db.Persons.Add(pers2);
                db.Persons.Add(pers3);

                // создаем два объекта StatusAggrement
                StatusAggrement statAgg1 = new StatusAggrement { Status = "Открыт" };
                StatusAggrement statAgg2 = new StatusAggrement { Status = "Открыт" };
                StatusAggrement statAgg3 = new StatusAggrement { Status = "Открыт" };

                db.StatusAggrements.Add(statAgg1);
                db.StatusAggrements.Add(statAgg2);
                db.StatusAggrements.Add(statAgg3);

                // создаем два объекта TypeAggrement
                TypeAggrement typeAgg1 = new TypeAggrement { Type = "Локальный" };
                TypeAggrement typeAgg2 = new TypeAggrement { Type = "Универсальный" };
                TypeAggrement typeAgg3 = new TypeAggrement { Type = "Универсальный" };
                
                db.TypeAggrements.Add(typeAgg1);
                db.TypeAggrements.Add(typeAgg2);
                db.TypeAggrements.Add(typeAgg3);

                db.SaveChanges();


                // создаем два объекта Agreement
                Agreement agr = new Agreement
                {
                    Number = 1,
                    DateOpen = new DateTime(2004, 3, 1, 7, 0, 0),
                    DateClose = new DateTime(2008, 3, 1, 7, 0, 0),
                    Person = pers1,
                    StatusAggrement = statAgg1,
                    TypeAggrement = typeAgg1
                };

                Agreement agr2 = new Agreement
                {
                    Number = 2,
                    DateOpen = new DateTime(2006, 3, 1, 7, 0, 0),
                    DateClose = new DateTime(2008, 3, 1, 7, 0, 0),
                    Person = pers2,
                    StatusAggrement = statAgg2,
                    TypeAggrement = typeAgg2
                };

                Agreement agr3 = new Agreement
                {
                    Number = 3,
                    DateOpen = new DateTime(2003, 3, 1, 7, 0, 0),
                    DateClose = new DateTime(2009, 3, 1, 7, 0, 0),
                    Person = pers3,
                    StatusAggrement = statAgg3,
                    TypeAggrement = typeAgg3
                };


                // добавляем их в БД
                db.Agreements.Add(agr);
                db.Agreements.Add(agr2);
                db.Agreements.Add(agr3);

                db.SaveChanges();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Initdb();
            textBlock.Text = "База данных создана. Объекты успешно сохранены. ";
        }
    }


}

