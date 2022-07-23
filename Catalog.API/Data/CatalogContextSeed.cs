using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            List<Product> products = new List<Product>();

            var p1 = new Product()
            {
                Id = "507f191e810c19729de860ea",
                Name = "Samsung S10e",
                Description = "Ut sequi officia qui corporis suscipit cum deserunt minus ea quidem expedita et voluptas perferendis sed totam perspiciatis. Et atque officia vel cupiditate rerum ea laboriosam quasi est iste vero est iste cupiditate ea quia doloribus eum unde repellat.",
                Image = "celulars10e.png",
                Price = 3500.00M,
                Category = "Smart Phone"

            };

            var p2 = new Product()
            {
                Id = "607f191e810c19729de860ea",
                Name = "Iphone XR",
                Description = "Ut sequi officia qui corporis suscipit cum deserunt minus ea quidem expedita et voluptas perferendis sed totam perspiciatis. Et atque officia vel cupiditate rerum ea laboriosam quasi est iste vero est iste cupiditate ea quia doloribus eum unde repellat.",
                Image = "celulars10e.png",
                Price = 3500.00M,
                Category = "Smart Phone"

            };

            var p3 = new Product()
            {
                Id = "707f191e810c19729de860ea",
                Name = "Xiaomi",
                Description = "Ut sequi officia qui corporis suscipit cum deserunt minus ea quidem expedita et voluptas perferendis sed totam perspiciatis. Et atque officia vel cupiditate rerum ea laboriosam quasi est iste vero est iste cupiditate ea quia doloribus eum unde repellat.",
                Image = "celulars10e.png",
                Price = 3500.00M,
                Category = "Smart Phone"

            };

            var p4 = new Product()
            {
                Id = "807f191e810c19729de860ea",
                Name = "Maquina de Lavar",
                Description = "Ut sequi officia qui corporis suscipit cum deserunt minus ea quidem expedita et voluptas perferendis sed totam perspiciatis. Et atque officia vel cupiditate rerum ea laboriosam quasi est iste vero est iste cupiditate ea quia doloribus eum unde repellat.",
                Image = "celulars10e.png",
                Price = 1500.00M,
                Category = "Eletro Domestico"

            };

            var p5 = new Product()
            {
                Id = "907f191e810c19729de860ea",
                Name = "Microondas",
                Description = "Ut sequi officia qui corporis suscipit cum deserunt minus ea quidem expedita et voluptas perferendis sed totam perspiciatis. Et atque officia vel cupiditate rerum ea laboriosam quasi est iste vero est iste cupiditate ea quia doloribus eum unde repellat.",
                Image = "celulars10e.png",
                Price = 3500.00M,
                Category = "Eletro Domestico"

            };

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);
            products.Add(p5);

            return products;
        }
    }
}
