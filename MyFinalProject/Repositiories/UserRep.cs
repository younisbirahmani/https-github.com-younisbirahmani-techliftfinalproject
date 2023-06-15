using Microsoft.AspNetCore.Mvc;
using MyFinalProject.Data;
using MyFinalProject.Models;

namespace MyFinalProject.Repositiories
{
    public class UserRep : IUserRep
    {
        private readonly ApplicationDbContext _context;

        public UserRep(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Create()
        {
            return _context.SaveChanges();
        }

        [HttpPost]
        public int Create(User d)
        {
            _context.Usertbl.Add(d);
            return _context.SaveChanges();
         
        }


       

        
        public int Update(User u)
        {
            _context.Usertbl.Update(u);
            return _context.SaveChanges();
        }




        public int Delete(int Id)
        {
            _context.Usertbl.Remove(_context.Usertbl.Where(a => a.UserID == Id).SingleOrDefault());
            return _context.SaveChanges();

        }

        


        public IEnumerable<User> ShowAll()
        {
            return _context.Usertbl.ToList();
        }

        public User ShowUser(int id)
        {
            return _context.Usertbl.Where(a => a.UserID == id).SingleOrDefault();
        }

		public int Detail(int id)
		{
		   _context.Usertbl.Remove(_context.Usertbl.Where(a => a.UserID == id).SingleOrDefault());
            return _context.SaveChanges();
		}

		public User ShowUserById(int id)
		{
            return _context.Usertbl.Where(a => a.UserID == id).SingleOrDefault();
		}
	}
}
