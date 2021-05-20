using onSale.Common.Entities;
using onSale.Web.Models;
using System;
using System.Threading.Tasks;

namespace onSale.Web.Helpers
{
    public interface IConverterHelper
    {
        Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew);

        CategoryViewModel ToCategoryViewModel(Category category);
        Task<Product> ToProductAsync(ProductViewModel model, bool isNew);
        ProductViewModel ToProductViewModel(Product product);
    }
}