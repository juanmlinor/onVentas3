using Microsoft.AspNetCore.Http;
using onSale.Common.Entities;
using System.ComponentModel.DataAnnotations;

namespace onSale.Web.Models
{
    public class CategoryViewModel:Category
    {
      [Display(Name = "Image")]
       public IFormFile ImageFile { get; set; }

    }
}
