using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;
using System;
using System.Collections.Generic;

namespace Tests.Helpers
{
    public static class DataHelper
    {
        public static User GetUser(string name)
        {
            HashingHelper.CreatePasswordHash("123456", out var passwordSalt, out var passwordHash);

            return new User()
            {
                Id = 1,
                Email = "test@test.com",
                PasswordHash = passwordSalt,
                PasswordSalt = passwordHash,
                Status = true,
            };
        }

        public static List<User> GetUserList()
        {
            HashingHelper.CreatePasswordHash("123456", out var passwordSalt, out var passwordHash);
            var list = new List<User>();

            for (var i = 1; i <= 5; i++)
            {
                var user = new User()
                {
                    Id = i,
                    Email = "test@test.com",
                    PasswordHash = passwordSalt,
                    PasswordSalt = passwordHash,
                    Status = true,
                };
                list.Add(user);
            }

            return list;
        }
    }
}