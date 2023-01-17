using DocumentAttribute.Docs;

namespace GettingMetaDataInfo.Implementation
{
    public class Docs
    {
        [Description("Sets the name of person")]
        public string? Name { get; set; }
        
        [Description("Sets the profession of person")]
        public string? Profession { get; set; }

        [Description("Gets the person's hobbies")]
        public string? Hobbies { get; set; }

        [Description("Gets the person's favorite athlete")]
        public string? BestAthlethe { get; set; }

        public Docs()
        {

        }
        public Docs(string name, string profession, string hobbies, string bestAthlethe)
        {
            Name = name;
            Profession = profession;
            Hobbies = hobbies;
            BestAthlethe = bestAthlethe;
        }

        public static List<Docs> persons = new List<Docs>();

        [Description("This method adds the new person to the list.")]
        public void DisplayUser()
        {
            persons.Add(new Docs("John Jones", "Doctor", "Reading", "Messi"));

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Name} | {person.Profession} | {person.Hobbies} | {person.BestAthlethe}");
            }
        }
    }
}