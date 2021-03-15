using NetlogProject.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetlogProject.Core.Auth
{
    public interface IAuthService
    {
        Task<Identity> Authenticate(string userName, string password);
    }
}
