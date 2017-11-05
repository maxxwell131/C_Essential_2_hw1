using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_task
{
    /*
     * Задание
        *Используя Visual Studio, создайте проект по шаблону Console Application.
        *Требуется:
        *Создать класс с именем Address.
        *В теле класса требуется создать поля: index, country, city, street, house, apartment. Для каждого
        *поля, создать свойство с двумя методами доступа.
        *Создать экземпляр класса Address.
        *В поля экземпляра записать информацию о почтовом адресе.
        *Выведите на экран значения полей, описывающих адрес.
*/
    class Program
    {
        static void Main(string[] args)
        {
            Address myAdress = new Address();
            myAdress.Index = "410041";
            myAdress.Countru = "USSR";
            myAdress.City = "Kyiv";
            myAdress.Street = "Lenina";
            myAdress.House = 9;
            myAdress.Apartament = 234;

            myAdress.AdressShow();

            //Delay.
            Console.ReadLine();
        }
    }
}
