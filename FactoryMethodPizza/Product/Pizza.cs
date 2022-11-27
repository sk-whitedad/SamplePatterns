namespace FactoryMethodPizza.Product
{
    public abstract class Pizza
    {
        public abstract void Bake();
        public abstract void Box();
        public abstract void Cut();
        public abstract void Prepare();
    }
}
