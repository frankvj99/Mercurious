using Mercurius.Entities;

namespace Mercurius.ViewModels
{
    public class OrderProductViewModel
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
