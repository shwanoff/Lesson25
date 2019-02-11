using System;
using System.Linq;

namespace Lesson25
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание
            // Исследовать рефлексию: Реализовать получение свойств, классов, методов
            // Создать свой собственный атрибут.
            // Использовать свой собственный атрибут в классе.

            var photo = new Photo("hello.png")
            {
                Path = @"C:\hello.png"
            };

            var type = typeof(Photo);
            var attributes = type.GetCustomAttributes(false);
            foreach(var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }

            var properties = type.GetProperties();
            foreach(var prop in properties)
            {
                var attrs = prop.GetCustomAttributes(false);

                if (attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
                {
                    Console.WriteLine(prop.PropertyType + " " + prop.Name);
                }

                //foreach(var a in attrs)
                //{
                //    Console.WriteLine(a);
                //}
            }


            Console.ReadLine();


        }
    }
}
