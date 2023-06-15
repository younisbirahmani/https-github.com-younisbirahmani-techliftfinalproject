using MyFinalProject.Models;

namespace MyFinalProject.Repositiories
{
    public interface IAddtoCart
    {
        AddtoCard Show(int id);

        
        AddtoCard ShowaddtocardById(int id);
        IEnumerable<AddtoCard> ShowAll();

    }
}
