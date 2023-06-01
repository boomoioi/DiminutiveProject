﻿namespace WebApplication2.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetById(string id);
        User Create(User user);
        void Update(string id,User user);
        void Delete(string id);
    }
}
