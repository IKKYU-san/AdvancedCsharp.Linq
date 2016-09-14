﻿
namespace AdvancedCsharp.Linq
{
    using Domain;
    using System.Linq;
    using static Helper;

    class LinqAssignement
    {
        // Ändra inget i denna metoden "Run()"

        public void Run()
        {
            Linq1();
            Linq2();
            Linq3();
            Linq4();
            Linq5();
            Linq6();
            Linq7(3);
            Linq7(1234);
            Linq8(3);
            Linq8(1234);
        }

        private void Linq1()
        {
            Header("Linq1");

            // Använd LINQ för att lösa uppgiften
            // Utgå ifrån "AllStudents"
            // Sortera studenterna utifrån födelsedag 
            DisplayList(TestData.AllStudents.OrderBy(x => x.Birthday));
        }


        private void Linq2()
        {
            Header("Linq2");

            // Använd LINQ för att lösa uppgiften
            // Utgå ifrån "AllStudents"
            // Ta fram de studenter som är födda 1984 eller är tidigare (alltså de som är gamla) och där favoritämnet är matematik
            // Sortera utefter Id
            DisplayList(TestData.AllStudents.OrderBy(x => x.Id).Where(x => x.Birthday.Year <= 1984 && x.FavoriteSubject == "Mathematics"));

        }


        private void Linq3()
        {
            Header("Linq3");

            // Lös förra uppgiften *utan* att använda Linq

        }


        private void Linq4()
        {
            Header("Linq4");

            // Använd LINQ för att lösa uppgiften
            // Utgå ifrån "AllStudents"
            // Ta fram de studenter som har matematik som favoritämne och räkna ihop hur många böcker de har tillsammans

        }

        private void Linq5()
        {
            Header("Linq5");

            // Använd LINQ för att lösa uppgiften
            // Utgå ifrån "SomeHighNumbersWithExtra"
            // Använd "Select"
            // Ta fram de nummer som är lägre än 300 och samtidigt är ett jämnt tal
            // Skapa en lista av strängar där du placerar en hakparantes runt varje heltal, t.ex [202]
            // Skriv sedan ut denna lista av strängar

        }

        private void Linq6()
        {
            Header("Linq6");

            // Använd LINQ för att lösa uppgiften
            // Utgå ifrån "AllStudents"
            // Använd "GroupBy" 

            // Gruppera studenterna utifrån vilket år de är födda
            // För varje grupp: Skriv ut en rubrik "Födelseår: XXXX" och under detta förnamnen på studenterna som fyller år detta år
            // I varje grupp ska studenterna vara sorterade på förnamn

        }


        private void Linq7(int id)
        {
            Header("Linq7");

            // Använd LINQ för att lösa uppgiften
            // Utgå ifrån "AllStudents"
            // Leta upp namnet på studenten med id't som skickas in som parameter
            // Om studenten inte finns så skriv ut detta

        }


        private void Linq8(int id)
        {
            Header("Linq8");

            // Använd LINQ för att lösa uppgiften
            // Utgå ifrån "AllStudents"
            // Använd "ToDictionary"
            // Bygg upp en dictionary utifrån alla studenter. Dictionary't ska bestå av Id och FirstName
            // Skriv ut dictionary't
            // Hämta sedan upp förnamnet på den student med det id som skickas in i metoden
            // Om id't inte finns i dictionary't så meddela användaren detta 

        }
    }
}
