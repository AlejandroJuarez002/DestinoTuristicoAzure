using ExploreSV.DataAccess;
using ExploreSV.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreSV.BusinessLogic.UseCases.Users.Queries.UserAuthentication
{
    public class UserAuthentication
    {

        private readonly ExploreSVContext _context;

        public UserAuthentication(ExploreSVContext context)
        {
            _context = context;
        }

        public async Task<User?> AuthenticateAsync(string name, string password)
        {
            return await _context.Users
                .Where(u => u.UserName == name && u.UserPassword == password)
                .FirstOrDefaultAsync();
        }
    }
}
