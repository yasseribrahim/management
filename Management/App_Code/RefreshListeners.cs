
namespace Management.App_Code
{
    public abstract class RefreshListeners
    {
        public interface ProductListener
        {
            void onAdded(Product product);
            void onUpdated(Product product);
        }

        public interface OrderListener
        {
            void onAdded(Order order);
            void onUpdated(Order order);
        }
    }
}
