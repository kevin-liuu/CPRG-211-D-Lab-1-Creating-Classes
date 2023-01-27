using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personslab
{
    internal class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColour;
        private bool isWorking;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string FavoriteColour { get => favoriteColour; set => favoriteColour = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public Person(int id, string firstName, string lastName, int age, string favoriteColour, bool isWorking)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.favoriteColour = favoriteColour;
            this.isWorking = isWorking;
            
        }
        public void DisplayPersonInfo() // Displays persons' full name, id and favorite color in a sentence 
        {
            Console.WriteLine(id + ":" + firstName + " " + lastName + "'s favorite color is " + favoriteColour);
        }

        public void ChangeFavoriteColor() // changes favorite color to white
        {
            this.favoriteColour = "White";
        }
        public void GetAgeInTenYear ()
        {
            Console.WriteLine(firstName + " " + lastName + "'s Age in 10 years is: " + (age + 10));
        }

        public override string ToString() //overriding tostring method to log on console
        {
            string formatted = "";

            formatted += "PersonID: " + id + "\n";
            formatted += "First Name: " + firstName + "\n";
            formatted += "Last Name: " + lastName + "\n";
            formatted += "Favorite Color: " + favoriteColour + "\n";
            formatted += "Age: " + age + "\n";
            formatted += "IsWorking: " + isWorking;
            return formatted;
        }
    }
}
