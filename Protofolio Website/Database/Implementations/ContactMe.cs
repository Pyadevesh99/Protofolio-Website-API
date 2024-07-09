using Login_and_Register_API.Database;
using Microsoft.Win32;
using Protofolio_Website.Database.Interface;
using Protofolio_Website.Db_Set;

namespace Protofolio_Website.Database.Implementations
{
    public class ContactMe : IContactMe
    {
        private readonly Db_Context _dbContext;

        public ContactMe(Db_Context dbContext)
        {
            _dbContext = dbContext;
        }

        // To register the data
        public async Task<bool> AddMessage(Message message)
        {
            try
            {
                await _dbContext.AddMessage.AddAsync(message);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
