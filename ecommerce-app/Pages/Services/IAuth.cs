using System;
using System.Threading.Tasks;

namespace ecommerce_app.Pages.Services
{
    public interface IAuth
    {

        public Task<string> GetToken(string phoneNumber);

    }
}
