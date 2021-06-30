using System;
using System.ComponentModel.DataAnnotations;

namespace SessionDI.Models
{
    public class Person
    {
        private string _fullname;
        private int _age;

        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Id { set; get; }
        public string FullNames
        {
            get
            {
                return FullNames = $"{LastName} {FirstName}";
            }
            set
            {
                _fullname = value;
            }
        }

        [Required]
        public string Gender { get; set; }

        public string BirthPlace { get; set; }

        [RegularExpression(@"^([0-9]{9,})$", ErrorMessage = "Wrong mobile"!)]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [EmailAddress]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        public bool IsGraduated { set; get; }

        public int Age
        {
            set
            {
                _age = value;
            }
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }

        public int CalculateAgeCorrect(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                age--;

            return Age;
        }
    }
}