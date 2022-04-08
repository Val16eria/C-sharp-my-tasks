using System;


namespace FitnessAppBL.Model
{
    public class User
    {
        public string Name { get; }

        public Gender Gender { get; }

        public DateTime BirthDate { get; }

        public double Weight { get; set; }

        public double Height { get; set; }

        public User(string name,
               Gender gender,
               DateTime birthDate,
               double weight,
               double height)
        {

        }
    }
}
