using System.Collections.Generic;

namespace Portfolio_Project.Models.Repository
{
    public interface IRepository
    {
        bool WriteContact(Contact contact);
        List<Project> GetProjects();
    }
}
