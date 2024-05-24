using MicroservicesECommerce.Web.Models;

namespace MicroservicesECommerce.Web.Services.Interfaces;

public interface IProductService
{
    Task<IEnumerable<ProductViewModel>> GetAllProducts();
    Task<ProductViewModel> FindProductById(int id);
    Task<ProductViewModel> CreateProduct(ProductViewModel productViewModel);
    Task<ProductViewModel> UpdateProduct(ProductViewModel productViewModel);
    Task<bool> DeleteProductById(int id);
}
