using System.Collections.Generic;

namespace Portfolio_Project.Models.Services
{
    public interface IServices
    {
        bool CreateContact(Contact contact);
        List<Project> GetAllProject();
    }
}
