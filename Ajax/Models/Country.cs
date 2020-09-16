using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ajax.Models
{
    public class Country
    {
        public int ID { get; set; }
        public int ContinentID { get; set; }
        public string Name { get; set; }

    }

    public class GeoService
    {
        static List<Country> _countries = new List<Country>()
        {
            new Country() { ContinentID = 1, ID = 1, Name = "France"},
            new Country() { ContinentID = 1, ID = 2, Name = "Spain"},
            new Country() { ContinentID = 1, ID = 3, Name = "Portugal"},
            new Country() { ContinentID = 1, ID = 4, Name = "Italy"},
            new Country() { ContinentID = 1, ID = 5, Name = "Denmark"},
            new Country() { ContinentID = 1, ID = 6, Name = "Greece"},
            new Country() { ContinentID = 2, ID = 7, Name = "China"},
            new Country() { ContinentID = 2, ID = 8, Name = "India"},
            new Country() { ContinentID = 2, ID = 9, Name = "Japan"},
            new Country() { ContinentID = 2, ID = 10, Name = "Korea"},
            new Country() { ContinentID = 2, ID = 11, Name = "Taiwan"},
            new Country() { ContinentID = 3, ID = 12, Name = "United States"},
            new Country() { ContinentID = 3, ID = 13, Name = "Brazil"},
            new Country() { ContinentID = 3, ID = 14, Name = "Mexico"},
            new Country() { ContinentID = 3, ID = 15, Name = "Colombia"},
            new Country() { ContinentID = 3, ID = 16, Name = "Argentina"},
        };

        public IEnumerable<Country> GetCountriesContinent(int continentID)
        {
            return _countries.Where(c => c.ContinentID == continentID);
        }
    }
}