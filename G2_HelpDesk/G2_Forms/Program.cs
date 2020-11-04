using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G2_Logic;
using G2_Model;

namespace G2_Forms
{
    static class Program
    {
        static List<string> lstNames = new List<string>();
        static List<string> lstSurNames = new List<string>();
        public static Random rnd = new Random();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FillFirstNames();
            FillLastNames();
            for (int i = 0; i < 100; i++)
            {
                //CreateAddUser();
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(LoginPage.Instance);
        }

        public static void CreateAddUser()
        {
            G2_Logic.PersonLogic g2 = new G2_Logic.PersonLogic();
            string name = lstNames.OrderBy(xx => rnd.Next()).First();
            string surname = lstSurNames.OrderBy(xx => rnd.Next()).First();
            string phoneNumber = GetRandomTelNo();
            string email = $"{name.ToLower()}.{surname.ToLower()}@gardengroup.com";
            Branch branch = (Branch)rnd.Next(0, 5);

            Employee e = new Employee(name,surname,phoneNumber,email,branch);
            //g2.AddEmployee(e);
        }


        static string GetRandomTelNo()
        {
            StringBuilder telNo = new StringBuilder(12);
            int number;
            for (int i = 0; i < 3; i++)
            {
                number = rnd.Next(0, 8); // digit between 0 (incl) and 8 (excl)
                telNo = telNo.Append(number.ToString());
            }
            telNo = telNo.Append("-");
            number = rnd.Next(0, 743); // number between 0 (incl) and 743 (excl)
            telNo = telNo.Append(String.Format("{0:D3}", number));
            telNo = telNo.Append("-");
            number = rnd.Next(0, 10000); // number between 0 (incl) and 10000 (excl)
            telNo = telNo.Append(String.Format("{0:D4}", number));
            return telNo.ToString();
        }

        static void FillLastNames()
        {
            lstSurNames.Add("Smith");
            lstSurNames.Add("Johnson");
            lstSurNames.Add("Williams");
            lstSurNames.Add("Jones");
            lstSurNames.Add("Brown");
            lstSurNames.Add("Davis");
            lstSurNames.Add("Miller");
            lstSurNames.Add("Wilson");
            lstSurNames.Add("Moore");
            lstSurNames.Add("Taylor");
            lstSurNames.Add("Anderson");
            lstSurNames.Add("Thomas");
            lstSurNames.Add("Jackson");
            lstSurNames.Add("White");
            lstSurNames.Add("Harris");
            lstSurNames.Add("Martin");
            lstSurNames.Add("Thompson");
            lstSurNames.Add("Garcia");
            lstSurNames.Add("Martinez");
            lstSurNames.Add("Robinson");
            lstSurNames.Add("Clark");
            lstSurNames.Add("Rodriguez");
            lstSurNames.Add("Lewis");
            lstSurNames.Add("Lee");
            lstSurNames.Add("Walker");
            lstSurNames.Add("Hall");
            lstSurNames.Add("Allen");
            lstSurNames.Add("Young");
            lstSurNames.Add("Hernandez");
            lstSurNames.Add("King");
            lstSurNames.Add("Wright");
            lstSurNames.Add("Lopez");
            lstSurNames.Add("Hill");
            lstSurNames.Add("Scott");
            lstSurNames.Add("Green");
            lstSurNames.Add("Adams");
            lstSurNames.Add("Baker");
            lstSurNames.Add("Gonzalez");
            lstSurNames.Add("Nelson");
            lstSurNames.Add("Carter");
            lstSurNames.Add("Mitchell");
            lstSurNames.Add("Perez");
            lstSurNames.Add("Roberts");
            lstSurNames.Add("Turner");
            lstSurNames.Add("Phillips");
            lstSurNames.Add("Campbell");
            lstSurNames.Add("Parker");
            lstSurNames.Add("Evans");
            lstSurNames.Add("Edwards");
            lstSurNames.Add("Collins");
            lstSurNames.Add("Stewart");
            lstSurNames.Add("Sanchez");
            lstSurNames.Add("Morris");
            lstSurNames.Add("Rogers");
            lstSurNames.Add("Reed");
            lstSurNames.Add("Cook");
            lstSurNames.Add("Morgan");
            lstSurNames.Add("Bell");
            lstSurNames.Add("Murphy");
            lstSurNames.Add("Bailey");
            lstSurNames.Add("Rivera");
            lstSurNames.Add("Cooper");
            lstSurNames.Add("Richardson");
            lstSurNames.Add("Cox");
            lstSurNames.Add("Howard");
            lstSurNames.Add("Ward");
            lstSurNames.Add("Torres");
            lstSurNames.Add("Peterson");
            lstSurNames.Add("Gray");
            lstSurNames.Add("Ramirez");
            lstSurNames.Add("James");
            lstSurNames.Add("Watson");
            lstSurNames.Add("Brooks");
            lstSurNames.Add("Kelly");
            lstSurNames.Add("Sanders");
            lstSurNames.Add("Price");
            lstSurNames.Add("Bennett");
            lstSurNames.Add("Wood");
            lstSurNames.Add("Barnes");
            lstSurNames.Add("Ross");
            lstSurNames.Add("Henderson");
            lstSurNames.Add("Coleman");
            lstSurNames.Add("Jenkins");
            lstSurNames.Add("Perry");
            lstSurNames.Add("Powell");
            lstSurNames.Add("Long");
            lstSurNames.Add("Patterson");
            lstSurNames.Add("Hughes");
            lstSurNames.Add("Flores");
            lstSurNames.Add("Washington");
            lstSurNames.Add("Butler");
            lstSurNames.Add("Simmons");
            lstSurNames.Add("Foster");
            lstSurNames.Add("Gonzales");
            lstSurNames.Add("Bryant");
            lstSurNames.Add("Alexander");
            lstSurNames.Add("Russell");
            lstSurNames.Add("Griffin");
            lstSurNames.Add("Diaz");
            lstSurNames.Add("Hayes");
        }
        public static void FillFirstNames()
        {
            lstNames.Add("Aiden");
            lstNames.Add("Jackson");
            lstNames.Add("Mason");
            lstNames.Add("Liam");
            lstNames.Add("Jacob");
            lstNames.Add("Jayden");
            lstNames.Add("Ethan");
            lstNames.Add("Noah");
            lstNames.Add("Lucas");
            lstNames.Add("Logan");
            lstNames.Add("Caleb");
            lstNames.Add("Caden");
            lstNames.Add("Jack");
            lstNames.Add("Ryan");
            lstNames.Add("Connor");
            lstNames.Add("Michael");
            lstNames.Add("Elijah");
            lstNames.Add("Brayden");
            lstNames.Add("Benjamin");
            lstNames.Add("Nicholas");
            lstNames.Add("Alexander");
            lstNames.Add("William");
            lstNames.Add("Matthew");
            lstNames.Add("James");
            lstNames.Add("Landon");
            lstNames.Add("Nathan");
            lstNames.Add("Dylan");
            lstNames.Add("Evan");
            lstNames.Add("Luke");
            lstNames.Add("Andrew");
            lstNames.Add("Gabriel");
            lstNames.Add("Gavin");
            lstNames.Add("Joshua");
            lstNames.Add("Owen");
            lstNames.Add("Daniel");
            lstNames.Add("Carter");
            lstNames.Add("Tyler");
            lstNames.Add("Cameron");
            lstNames.Add("Christian");
            lstNames.Add("Wyatt");
            lstNames.Add("Henry");
            lstNames.Add("Eli");
            lstNames.Add("Joseph");
            lstNames.Add("Max");
            lstNames.Add("Isaac");
            lstNames.Add("Samuel");
            lstNames.Add("Anthony");
            lstNames.Add("Grayson");
            lstNames.Add("Zachary");
            lstNames.Add("David");
            lstNames.Add("Christopher");
            lstNames.Add("John");
            lstNames.Add("Isaiah");
            lstNames.Add("Levi");
            lstNames.Add("Jonathan");
            lstNames.Add("Oliver");
            lstNames.Add("Chase");
            lstNames.Add("Cooper");
            lstNames.Add("Tristan");
            lstNames.Add("Colton");
            lstNames.Add("Austin");
            lstNames.Add("Colin");
            lstNames.Add("Charlie");
            lstNames.Add("Dominic");
            lstNames.Add("Parker");
            lstNames.Add("Hunter");
            lstNames.Add("Thomas");
            lstNames.Add("Alex");
            lstNames.Add("Ian");
            lstNames.Add("Jordan");
            lstNames.Add("Cole");
            lstNames.Add("Julian");
            lstNames.Add("Aaron");
            lstNames.Add("Carson");
            lstNames.Add("Miles");
            lstNames.Add("Blake");
            lstNames.Add("Brody");
            lstNames.Add("Adam");
            lstNames.Add("Sebastian");
            lstNames.Add("Adrian");
            lstNames.Add("Nolan");
            lstNames.Add("Sean");
            lstNames.Add("Riley");
            lstNames.Add("Bentley");
            lstNames.Add("Xavier");
            lstNames.Add("Hayden");
            lstNames.Add("Jeremiah");
            lstNames.Add("Jason");
            lstNames.Add("Jake");
            lstNames.Add("Asher");
            lstNames.Add("Micah");
            lstNames.Add("Jace");
            lstNames.Add("Brandon");
            lstNames.Add("Josiah");
            lstNames.Add("Hudson");
            lstNames.Add("Nathaniel");
            lstNames.Add("Bryson");
            lstNames.Add("Ryder");
            lstNames.Add("Justin");
            lstNames.Add("Bryce");

            //—————female

            lstNames.Add("Sophia");
            lstNames.Add("Emma");
            lstNames.Add("Isabella");
            lstNames.Add("Olivia");
            lstNames.Add("Ava");
            lstNames.Add("Lily");
            lstNames.Add("Chloe");
            lstNames.Add("Madison");
            lstNames.Add("Emily");
            lstNames.Add("Abigail");
            lstNames.Add("Addison");
            lstNames.Add("Mia");
            lstNames.Add("Madelyn");
            lstNames.Add("Ella");
            lstNames.Add("Hailey");
            lstNames.Add("Kaylee");
            lstNames.Add("Avery");
            lstNames.Add("Kaitlyn");
            lstNames.Add("Riley");
            lstNames.Add("Aubrey");
            lstNames.Add("Brooklyn");
            lstNames.Add("Peyton");
            lstNames.Add("Layla");
            lstNames.Add("Hannah");
            lstNames.Add("Charlotte");
            lstNames.Add("Bella");
            lstNames.Add("Natalie");
            lstNames.Add("Sarah");
            lstNames.Add("Grace");
            lstNames.Add("Amelia");
            lstNames.Add("Kylie");
            lstNames.Add("Arianna");
            lstNames.Add("Anna");
            lstNames.Add("Elizabeth");
            lstNames.Add("Sophie");
            lstNames.Add("Claire");
            lstNames.Add("Lila");
            lstNames.Add("Aaliyah");
            lstNames.Add("Gabriella");
            lstNames.Add("Elise");
            lstNames.Add("Lillian");
            lstNames.Add("Samantha");
            lstNames.Add("Makayla");
            lstNames.Add("Audrey");
            lstNames.Add("Alyssa");
            lstNames.Add("Ellie");
            lstNames.Add("Alexis");
            lstNames.Add("Isabelle");
            lstNames.Add("Savannah");
            lstNames.Add("Evelyn");
            lstNames.Add("Leah");
            lstNames.Add("Keira");
            lstNames.Add("Allison");
            lstNames.Add("Maya");
            lstNames.Add("Lucy");
            lstNames.Add("Sydney");
            lstNames.Add("Taylor");
            lstNames.Add("Molly");
            lstNames.Add("Lauren");
            lstNames.Add("Harper");
            lstNames.Add("Scarlett");
            lstNames.Add("Brianna");
            lstNames.Add("Victoria");
            lstNames.Add("Liliana");
            lstNames.Add("Aria");
            lstNames.Add("Kayla");
            lstNames.Add("Annabelle");
            lstNames.Add("Gianna");
            lstNames.Add("Kennedy");
            lstNames.Add("Stella");
            lstNames.Add("Reagan");
            lstNames.Add("Julia");
            lstNames.Add("Bailey");
            lstNames.Add("Alexandra");
            lstNames.Add("Jordyn");
            lstNames.Add("Nora");
            lstNames.Add("Carolin");
            lstNames.Add("Mackenzie");
            lstNames.Add("Jasmine");
            lstNames.Add("Jocelyn");
            lstNames.Add("Kendall");
            lstNames.Add("Morgan");
            lstNames.Add("Nevaeh");
            lstNames.Add("Maria");
            lstNames.Add("Eva");
            lstNames.Add("Juliana");
            lstNames.Add("Abby");
            lstNames.Add("Alexa");
            lstNames.Add("Summer");
            lstNames.Add("Brooke");
            lstNames.Add("Penelope");
            lstNames.Add("Violet");
            lstNames.Add("Kate");
            lstNames.Add("Hadley");
            lstNames.Add("Ashlyn");
            lstNames.Add("Sadie");
            lstNames.Add("Paige");
            lstNames.Add("Katherine");
            lstNames.Add("Sienna");
            lstNames.Add("Piper");
        }
    }
}
