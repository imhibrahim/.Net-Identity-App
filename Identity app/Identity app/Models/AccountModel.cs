using Identity_app.Data;
using Identity_app.DTOs;
using Identity_app.Repositories;

namespace Identity_app.Models
{
    public class AccountModel : IAccount

    {

        private readonly ApplicationDbContext context;

        public AccountModel(ApplicationDbContext context)
        {

            this.context = context;

        }

        public void CreateUserAccount(AccountDTO accountDTO)
        {

           
      

            try
            {

            }

            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
