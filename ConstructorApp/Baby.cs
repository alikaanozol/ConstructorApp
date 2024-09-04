using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    public class Baby
    {   //Özellikler || Proporties
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateofBirth { get; set; }

        // Default Constructor
        public Baby()
        {
            DateofBirth = DateTime.Now;
            Console.WriteLine("Ingaaaaa,bebek doğdu :)\n");

        }

        // Parametre Alan Constructor
        public Baby(string name, string surname)
        {
            Name = name;
            Surname = surname;
            DateofBirth = DateTime.Now;
            Console.WriteLine("Ingaaaaa,bebek doğdu :)\n");

        }
        //Bebeğe dair bilgileri görüntüleme || Method to display baby's details
        public void ShowInformation()
        {
            Console.WriteLine($"Doğan bebeğimizin Adı : {Name}, Soyadı : {Surname}, Doğum Tarihi : {DateofBirth}\n");
        }
    }
}
