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

        public List<Person> ReadByPersonName(string PersonName)
        {
            var q = ctx.Person.Where(h => h.Name == PersonName);

            return q.ToList();
        }

        public Person ReadByPersonID(int id)
        {
            var query = ctx.Person.FirstOrDefault(h => h.Id == id);
            return query;
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
