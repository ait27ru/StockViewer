using System;
using System.Threading.Tasks;

namespace StockMarket
{
    public interface IAuthenticationService
    {
        /// <summary>
        ///     Authenticates the given user/password, returning the user's ID
        ///     as a GUID on success, or null on failure.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<Guid?> AuthenticateUserAsync(string user, string password);
    }
}