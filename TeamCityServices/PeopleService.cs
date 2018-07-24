using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamCity.Model;

namespace TeamCityServices
{
    public class PeopleService
    {
        
        public IEnumerable<Person> GetPeople()
        {
            TCDbContext db = new TCDbContext();
            return db.People;
        }

    }
}
