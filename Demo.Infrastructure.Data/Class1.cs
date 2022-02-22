using System;
using System.Collections.Generic;
using System.Threading;

namespace Demo.Infrastructure.Data
{
    public  class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
    }
    public class InMemoryDbContext : IDisposable
    {
        public InMemoryDbContext()
        {
            Thread.Sleep(4000);
        }
        public List<User> Users { get; set; } = new List<User>();
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
