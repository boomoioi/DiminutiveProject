using MongoDB.Bson;
using MongoDB.Driver;
using WebApplication2.Models;
using ZstdSharp.Unsafe;

namespace WebApplication2.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IDatabaseSettings settings, IMongoClient mongoClient) 
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _users = database.GetCollection<User>(settings.UserCollectionName);

        }

        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        public void Delete(string id)
        {
            _users.DeleteOne(user => user.Id == id);

        }

        public User GetById(string id)
        {
            return _users.Find(user => user.Id == id).FirstOrDefault();
        }

        public List<User> GetUsers()
        {
            return _users.Find(user => true).ToList();

        }
        public void Update(string id, User user)
        {
            _users.ReplaceOne(user => user.Id == id, user);
        }
    }
}
