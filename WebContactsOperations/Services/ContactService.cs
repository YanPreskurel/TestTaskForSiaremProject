using WebContactsOperations.Interfaces;
using WebContactsOperations.Models;

namespace WebContactsOperations.Services
{
    public class ContactService : IContactService
    {

        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<IEnumerable<Contact>> GetAllAsync() => 
            await _contactRepository.GetAllAsync();

        public async Task<Contact?> GetByIdAsync(int id)
        {
            if (id <= 0)
                return null;

            return await _contactRepository.GetByIdAsync(id);
        }

        public async Task CreateAsync(Contact contact)
        {
            if(contact is null)
                throw new ArgumentNullException(nameof(contact));

            await _contactRepository.AddAsync(contact);
            await _contactRepository.SaveAsync();
        }

        public async Task UpdateAsync(Contact contact)
        {
            if (contact is null)
                throw new ArgumentException("Incorrect contact data");

            await _contactRepository.UpdateAsync(contact);
            await _contactRepository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            if (id <= 0)
                return;

            var contact = await _contactRepository.GetByIdAsync(id);

            if(contact is null)
                throw new ArgumentNullException(nameof(contact));

            await _contactRepository.DeleteAsync(contact);
            await _contactRepository.SaveAsync();
        }
    }
}
