using MyFinalProject.Models;

namespace MyFinalProject.Repositiories
{
    public interface ICategoryRep
    {
        Category ShowCat(int id);

        int Create(Category d);

        int Update(Category c);

        int Detail(int id);


        // Category Detailscat(int id);
        int Delete(int Id);

        Category ShowCatById(int id);
        IEnumerable<Category> ShowAll();

    }
}
