using Data.Entities;
using Laboratorium_3.Models;

namespace Laboratorium_3.Mappers
{
    public class ContactMapper
    {
        public static Contact FromEntity(ContactEntity entity)
        {
            return new Contact()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email
            };
        }

        public static ContactEntity ToEntity(Contact model)
        {
            return new ContactEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email,
            };
        }
    }
}
