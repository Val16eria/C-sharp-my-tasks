using FitnessAppBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FitnessAppBL.Controller
{
    /// <summary>
    /// Контроллер пользователя.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Пользователь приложения.
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Создание нового контроллера пользователя.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="genderName"></param>
        /// <param name="birdthDay"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        public UserController(string userName, string genderName, DateTime birdthDay, double weight, double height)
        {
            //TODO: Проверка

            var gender = new Gender(genderName);
            User = new User(userName, gender, birdthDay, weight, height);
        }

        public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.data", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }

                //TODO: Что делать, если пользователя не прочитали?
            }
        }

        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.data", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }

        /// <summary>
        /// Получить данные пользователя.
        /// </summary>
        /// <returns> Пользователь приложения. </returns>

    }
}
