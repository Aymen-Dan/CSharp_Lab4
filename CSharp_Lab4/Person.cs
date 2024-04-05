using System;

namespace CSharp_Lab2_ParsonApp
{
    internal class Person
    {
        // Fields
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _email;
        private readonly DateTime _dateOfBirth;

        // Constructor
        public Person(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _dateOfBirth = dateOfBirth.Date;
        }

        // Getters
        public string GetFirstName() => _firstName;
        public string GetLastName() => _lastName;
        public string GetEmail() => _email;
        public string GetDateOfBirth() => _dateOfBirth.ToString("dd/MM/yyyy");

        // Properties
        public bool IsAdult => CalculateIsAdult();
        public string SunSign => CalculateSunSign();
        public string ChineseSign => CalculateChineseSign();
        public bool IsBirthday => CalculateIsBirthday();

        // Helper methods
        private bool CalculateIsAdult()
        {
            int age = DateTime.Today.Year - _dateOfBirth.Year;
            if (DateTime.Today < _dateOfBirth.AddYears(age))
            {
                age--;
            }
            return age >= 18;
        }

        private string CalculateSunSign()
        {
            int month = _dateOfBirth.Month;
            int day = _dateOfBirth.Day;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
            {
                return "Aries";
            }
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
            {
                return "Taurus";
            }
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
            {
                return "Gemini";
            }
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
            {
                return "Cancer";
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            {
                return "Leo";
            }
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
            {
                return "Virgo";
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
            {
                return "Libra";
            }
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
            {
                return "Scorpio";
            }
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            {
                return "Sagittarius";
            }
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
            {
                return "Capricorn";
            }
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            {
                return "Aquarius";
            }
            else //February 19 to March 20
            {
                return "Pisces";
            }
        }

        private string CalculateChineseSign()
        {
            //Start from 1900 y
            int startYear = 1900;

            //calculate the offset from the start year
            int offset = _dateOfBirth.Year - startYear;

            //animal signs of the Chinese zodiac cycle
            string[] animalSigns = { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };

            //Calculate index
            int index = (offset + 12) % 12;

            //Return the animal sign
            return animalSigns[index];
        }

        private bool CalculateIsBirthday()
        {
            return _dateOfBirth.Month == DateTime.Today.Month && _dateOfBirth.Day == DateTime.Today.Day;
        }
    }
}
