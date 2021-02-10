namespace CQRS
{
    using System;
    using Interfaces;
    using Queries;
    using Unity;

    class Program
    {
        static void Main(string[] args)
        {
            UnityConfig.Register();

            // Manual resolve for console app. This is not required for web app.
            var queryHandler = UnityConfig.UnityContainer.Resolve<IQueryHandler>();

            var input = new ProductIdRequest
            {
                Id = 100
            };

            var output = queryHandler.ExecuteQuery<ProductIdRequest, ProductEntity>(input);

            Console.WriteLine(output.ProductName);
        }
    }
}
