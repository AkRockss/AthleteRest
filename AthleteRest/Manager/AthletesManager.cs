using AtheleteLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AthleteRest.Manager
{
    public class AthletesManager
    {
        private static int _nextId = 1;

        private static readonly List<Athlete> Data = new List<Athlete>
        {
            new Athlete {Id = _nextId++, Name = "Jan", Country = "Danmark", Height = 1.87},
            new Athlete {Id = _nextId++, Name = "Svend", Country = "Danmark", Height = 1.90},
            new Athlete {Id = _nextId++, Name = "Diana", Country = "Danmark", Height = 2.10},
            new Athlete {Id = _nextId++, Name = "Katrine", Country = "Norge", Height = 1.67},
            new Athlete {Id = _nextId++, Name = "Marie", Country = "Sverige", Height = 1.76},
        };
        
        public List<Athlete> GetAll(string contains, string sortBy = null)
        {
            List<Athlete> ath = new List<Athlete>(Data);

            if (sortBy != null)
            {
                switch (sortBy.ToLower())
                {
                    case "height":
                        ath = ath.OrderByDescending(ath => ath.Height).ToList();
                        break;

                       
                }
            }
                return ath;
        }

        public Athlete Add(Athlete newAthlete)
        {
            newAthlete.Id = _nextId++;
            Data.Add(newAthlete);
            return newAthlete;
        }


        public List<Athlete> GetByCountry(string country)
        {
            List<Athlete> athlete = new List<Athlete>(Data);
            {
                if (country != null)
                {
                    athlete = athlete.FindAll(athlete => athlete.Country != null && athlete.Country.StartsWith(country));

                }
                return athlete;
            }
        }



        public Athlete Delete(int id)
        {
            Athlete athlete = Data.Find(Ath1 => Ath1.Id == id);
            if (athlete == null) return null;
            Data.Remove(athlete);
            return athlete;
        }




    }
}
