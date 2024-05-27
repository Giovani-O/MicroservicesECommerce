using MicroservicesECommerce.Web.Models;

namespace MicroservicesECommerce.Web.Services.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<CategoryViewModel>> GetAllCategories();
}
