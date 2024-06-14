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

        public Person GetPersonById(int id)
        {
            return PersonDAL.GetPersonById(id);
        }

        public List<Person> searchPersonByString(string pesonname)
        {
            return PersonDAL.SearchPerson(pesonname);
        }

        public int getpersonIdByName(string name)
        {
            return PersonDAL.GetPersonIdByName(name);
        }
        

    }
}
