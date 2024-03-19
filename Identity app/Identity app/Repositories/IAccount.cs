using Identity_app.DTOs;

namespace Identity_app.Repositories
{
    public interface IAccount
    {

        public void CreateUserAccount(AccountDTO accountDTO);
    }
}
