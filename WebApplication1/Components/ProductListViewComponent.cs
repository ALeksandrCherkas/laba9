using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Components
{
    public class ProductListViewComponent : ViewComponent
    {
        List<ProductModel> productList = new List<ProductModel>
        {
            new ProductModel(1, "Випарник Smok RPM 3", 125),
            new ProductModel(2, "Картридж Smok Nord 4", 99),
            new ProductModel(3, "Картридж Smok RPM", 130),
            new ProductModel(4, "Випарник Smok RPM 2", 120)
        };
        public IViewComponentResult Invoke()
        {
            return View(productList);
        }
    }
}
