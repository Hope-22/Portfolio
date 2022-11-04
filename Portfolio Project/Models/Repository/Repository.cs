using Portfolio_Project.data;
using System.Collections.Generic;

namespace Portfolio_Project.Models.Repository
{
    public class Repository : IRepository
    {
        private readonly Seeder _seeder;
        private readonly string _project = "Project.json";
        private readonly string _contact = "Contact.json";

        public Repository()
        {
            _seeder = new Seeder();
        }
        public List<Project> GetProjects()
        {
            var projects = _seeder.ReadJson<Project>(_project);
            return projects;
        }

        public bool WriteContact(Contact contact)
        {
            var write = _seeder.WriteJson<Contact>(contact, _contact);
            return write;
        }
    }
}
