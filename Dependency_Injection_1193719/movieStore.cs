using System;
using System.Collections.Generic;

namespace Dependency_Injection_1193719
{
    public interface ISingleton
    {

    }
    public class movieStore : user, ISingleton, IMovieStoreService
    {
        public string name { get; set; }
        public List<user> users { get; set; }

        public movieStore()
        {
            string[] stores = new string [] {"MS1", "MS2", "MS3"};
            name = stores[new Random().Next(stores.Length)];
        }

        public string[] GetUsers()
        {
            string[] users = new string[] { "Maria", "Luis", "Andrea", "Sofía", "Melisa", "Andrea" };
            string[] usersOfStore = new string[2];
            for (int i = 0; i < 2; i++)
            {
                usersOfStore[i] = users[new Random().Next(users.Length)];
            }

            return usersOfStore;
        }
    }
}
