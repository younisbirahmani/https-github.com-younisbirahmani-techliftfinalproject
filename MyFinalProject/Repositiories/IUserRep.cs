using MyFinalProject.Models;

namespace MyFinalProject.Repositiories
{
    public interface IUserRep
    {
        User ShowUser(int id);

        int Create(User d);

        int Update(User u);

        int Detail(int id);

        int Delete(int Id);

        User ShowUserById(int id);
        

        IEnumerable<User> ShowAll();





    }
}
