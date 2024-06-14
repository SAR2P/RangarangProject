using BuisnesEntityLayer.Entities;
using DataAccessLayer.Context;


namespace DataAccessLayer.Models
{
    public class PersonBLL
    {
      PersonDAL PersonDAL = new PersonDAL(); 


        public List<Person> GetAll()
        {
            return PersonDAL.ReadPerson();
        }
    }
}
