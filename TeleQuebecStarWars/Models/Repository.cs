using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TeleQuebecStarWars.Models
{
    public class Repository : IRepository
    {
        public Repository()
        {
            using (StreamReader file = File.OpenText(@"Data\starwars.json"))
            {
                Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                Personnages = (List<PersonnageModel>)serializer.Deserialize(file, typeof(List<PersonnageModel>));
            }
        }

        public IEnumerable<PersonnageModel> Personnages { get; }
    }
}
