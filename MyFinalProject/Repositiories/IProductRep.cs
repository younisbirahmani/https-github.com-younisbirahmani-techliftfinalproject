using MyFinalProject.Models;
using MyFinalProject.Models.VMs;

namespace MyFinalProject.Repositiories
{
    public interface IProductRep
    {
        Product ShowProd(int id);

        int Create(Product d);

        int Update(Product u);

        int Detail(int id);

        int Delete(int Id);

        Product ShowProdById(int id);


        IEnumerable<Product> ShowAll();

     





    }
}
