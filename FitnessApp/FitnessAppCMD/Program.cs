using FitnessAppBL.Controller;
using FitnessAppBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAppCMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует FitnessApp");

            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine(); 

            var userController = new UserController(name);
            if(userController.IsNewUser)
            {
                Console.WriteLine("Введите Пол: ");
                var gender = Console.ReadLine();
                DateTime birthDate;

                while(true)
                {
                    Console.WriteLine("Введите дату рождения (dd.MM.yyyy): ");
                    if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат даты рождения");
                    }
                }


                userController.SetNewUserData();
            }
            Console.WriteLine(userController.CurrentUser);
            Console.ReadLine();

        }
    }
}
