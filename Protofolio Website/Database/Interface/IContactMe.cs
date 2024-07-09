using Protofolio_Website.Db_Set;

namespace Protofolio_Website.Database.Interface
{
    public interface IContactMe
    {
        Task<bool> AddMessage(Message message);
    }
}
