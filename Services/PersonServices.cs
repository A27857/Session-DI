using System;
using System.Collections.Generic;
using System.Linq;
using SessionDI.Models;

namespace SessionDI
{
    public class PersonServices : IPersonServices
    {
        static List<Person> _members = new List<Person>
        {
            new Person{
                Id = 18,
                FirstName = "Long",
                LastName = "Bao",
                Gender = "Male",
                DateOfBirth = new DateTime(1994,1,16),
                PhoneNumber="",
                BirthPlace = "Bac Ninh",
                IsGraduated  = false,
                Age = 27
            },
            new Person{
                Id = 14,
                FirstName = "Dat",
                LastName = "Dam Tuan",
                Gender = "Male",
                DateOfBirth = new DateTime(1996,7,14),
                PhoneNumber="",
                BirthPlace = "Ha noi",
                IsGraduated  = true,
                Age = 25
            },
            new Person{
                Id = 11,
                FirstName = "Hung",
                LastName = "Ngo Quoc",
                Gender = "Male",
                DateOfBirth = new DateTime(1991,3,7),
                PhoneNumber="",
                BirthPlace = "Hai Phong",
                IsGraduated  = false,
                Age = 30
            },
            new Person{
                Id = 19,
                FirstName = "Van",
                LastName = "Nguyen Cong",
                Gender = "Male",
                DateOfBirth = new DateTime(1998,4,5),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                IsGraduated  = true,
                Age = 23
            },
            new Person{
                Id = 3,
                FirstName = "Trang",
                LastName = "Nguyen Huyen",
                Gender = "Female",
                DateOfBirth = new DateTime(2002,7,14),
                PhoneNumber="",
                BirthPlace = "Hai Duong",
                IsGraduated  = false,
                Age = 19
            },
            new Person{
                Id = 6,
                FirstName = "Ky",
                LastName = "Nguyen Khac",
                Gender = "Male",
                DateOfBirth = new DateTime(1999,11,12),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                IsGraduated  = false,
                Age = 22
            },
            new Person{
                Id = 8,
                FirstName = "Phuoc",
                LastName = "Hoang",
                Gender = "Male",
                DateOfBirth = new DateTime(2000,11,25),
                PhoneNumber="",
                BirthPlace = "Hai Phong",
                IsGraduated  = false,
                Age = 21
            },
            new Person{
                Id = 9,
                FirstName = "Hung",
                LastName = "Bui",
                Gender = "Male",
                DateOfBirth = new DateTime(1983,11,13),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                IsGraduated  = true,
                Age = 38
            }
        };
        
        public List<Person> GetAll()
        {
            return _members;
        }

        public Person GetOne(int id)
        {
            var person = _members.Where(p => p.Id == id).FirstOrDefault();
            return person;
        }

        public void Create(Person person)
        {
            _members.Add(person);
        }

        public void Update(Person person)
        {
            var list = _members.Where(p => p.Id != person.Id).ToList();
            list.Insert(0, person);
            _members = list;
        }

        public void Delete(int id)
        {
            var list = _members.Where(p => p.Id != id).ToList();
            _members = list;
        }
    }
}