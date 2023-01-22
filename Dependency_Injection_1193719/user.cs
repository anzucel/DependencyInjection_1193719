using System;
using System.Collections.Generic;

namespace Dependency_Injection_1193719
{
    public class user : movies, IUserService
    {
        public string userName { get; set; }
        public List<movies> movies { get; set; }

        public List<user> GetUsersInfo(string[] username)
        {
            List<user> newUser = new List<user>();

            for (int i = 0; i < username.Length; i++)
            {
                user user = new user();
                user.userName = username[i];
                user.movies = GetMovies();
                newUser.Add(user);
            }
            return newUser;
        }
    }
}
