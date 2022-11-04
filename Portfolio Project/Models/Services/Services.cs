using Portfolio_Project.Models.Repository;
using System.Collections.Generic;

namespace Portfolio_Project.Models.Services
{
    public class Services : IServices
    {
        private readonly IRepository _repository;

        public Services(IRepository repository)
        {
            _repository = repository;
        }

        public bool CreateContact(Contact contact)
        {
           var result = _repository.WriteContact(contact);
            return result;
        }

        public List<Project> GetAllProject()
        {
            var list = _repository.GetProjects();
            return list;    
        }
    }
}
