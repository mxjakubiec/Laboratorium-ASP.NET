using Data.Entities;

namespace Laboratorium_3.Models.Memory
{
    public class MemoryContactService : IContactService
    {
        private readonly IDateTimeProvider _timeProvider;
        private Dictionary<int, Contact> _items = new Dictionary<int, Contact>();

        public MemoryContactService(IDateTimeProvider timeProvider) {
            this._timeProvider = timeProvider;
        }

        public int Add(Contact item)
        {
            //item.Created = _timeProvider.DateNow();
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
            _items.Add(item.Id, item);
            return item.Id;
        }

        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<Contact> FindAll()
        {
            return _items.Values.ToList();
        }

        public List<OrganizationEntity> FindAllOrganizationsForVieModel()
        {
            return new List<OrganizationEntity>();
        }

        public Contact? FindById(int id)
        {
            return _items[id];
        }

        public PagingList<Contact> FindPage(int page, int size)
        {
            return null;
        }

        public void Update(Contact item)
        {
            _items[item.Id] = item;
        }
    }
}
