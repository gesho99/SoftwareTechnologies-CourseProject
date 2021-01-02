using Autofac.Extras.Moq;
using RestaurantSystem.Controllers;
using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RestaurantSystem.MockTests
{
    public class ProductsInStockTests
    {
        ProductsInStockForm psf = new ProductsInStockForm();

        [Fact]
        public void LoadProductsFromDataBase_ValidCall()
        {
            using(var mock = AutoMock.GetLoose())
            {
                mock.Mock<Controller>()
                    .Setup(x => x.LoadProducts())
                    .Returns(GetSampleProducts());

                var cls = mock.Create<ProductsInStockForm>();
                var expected = GetSampleProducts();

                var actual = cls.LoadProductsFromDataBase();

                Assert.True(actual != null);
                Assert.Equal(expected.Count, actual.Count);

                for(int i = 0; i < expected.Count; i++){
                    Assert.Equal(expected.ElementAt(i).Name, actual.ElementAt(i).Name);
                }

            }
        }

        private ICollection<Product> GetSampleProducts()
        {
            ICollection<Product> products = new HashSet<Product>
            {
                new Product
                {
                    Name = "tomatoe",
                    Price = 2.5,
                    DeliveryPrice = 2.5,
                    Quantity = 20
                },

                new Product
                {
                    Name = "banana",
                    Price = 2.6,
                    DeliveryPrice = 2.6,
                    Quantity = 30
                }
            };

            return products;
        }

    }
}
