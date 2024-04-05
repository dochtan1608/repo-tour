
namespace MainTour.Models.ViewModels
{
    public class ProductListVIewModel
    {
        public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();
        public PagingInfo PagingInfo { get; set; } = new PagingInfo();
    }
}
