namespace Catalog.API.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() : base("Product not Found!")
        {

        }

    }
}

//In C#, the base keyword is used to refer to the base class (parent class of the current class)
//It allows you to call a base class constructor and access base class members