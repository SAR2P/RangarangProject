using BuisnesEntityLayer.Entities;
using DataAccessLayer.Context;


namespace DataAccessLayer.Models
{
    public class PersonDAL
    {
        RangarangDbContext ctx = new RangarangDbContext();


        public void createPerson(Person c)
        {
            ctx.Person.Add(c);
            ctx.SaveChanges();
        }

        public List<Person> ReadPerson()
        {
            return ctx.Person.ToList();
        }

     
        public List<Person> SearchPerson(string persontext)
        {
            //var query = ctx.Person.Where(x => x.Name.Contains(persontext)).ToList();
            var query = ctx.Person.Where(x => x.Name.Contains(persontext) || x.CompanyName.Contains(persontext) || x.Tell.Contains(persontext) 
            || x.Email.Contains(persontext)).ToList();
            return query;
        }

       public Person GetPersonById(int id)
        {
            var query = ctx.Person.Where(x => x.Id == id).FirstOrDefault();
            return query;
        }

        public int GetPersonIdByName(string name)
        {
            var query = ctx.Person.Where(p => p.Name == name).FirstOrDefault();
            return query.Id;
        }


        public void UpdateProductById(int id, Person NewPerson)
        {
            var query = ctx.Person.Where(h => h.Id == id);

            if (query.Count() == 1)
            {
                Person NPerson = new Person();

                NPerson = query.Single();
                NPerson.Name = NewPerson.Name;
                NPerson.CompanyName = NewPerson.CompanyName;
                NPerson.Tell = NewPerson.Tell;
                NPerson.Email = NewPerson.Email;
                ctx.SaveChanges();

            }
        }

        public void DeletProductById(int id)
        {
            var query = from i in ctx.Person where i.Id == id select i;

            if (query.Count() == 1)
            {
                ctx.Person.Remove(query.Single());
                ctx.SaveChanges();

            }


        }
    }
}
