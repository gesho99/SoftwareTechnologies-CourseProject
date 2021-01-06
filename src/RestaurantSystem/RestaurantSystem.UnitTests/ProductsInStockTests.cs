using RestaurantSystem.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit;

namespace RestaurantSystem.UnitTests
{
    public class ProductsInStockTests
    {
        ProductsInStockForm psf = new ProductsInStockForm();

        [Theory]
        [InlineData("50", "2,50", "2,50", "lemon")]
        [InlineData("50", "2", "2", "lemon")]
        public void ProductValidation_ShouldPass(string productQuantity, string productPrice, string deliveryPrice, string productName)
        {
            //Arrange
            bool expected = true;

            //Act
            bool actual = psf.ProductValidation(productQuantity, productPrice, deliveryPrice, productName);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("-1", "2,50", "2,50", "lemon")]
        [InlineData("1", "0", "2,50", "lemon")]
        [InlineData("1", "2,50", "0", "lemon")]
        [InlineData("1", "2,50", "2,50", "")]
        [InlineData("1", "a", "2,50", "lemon")]
        [InlineData("1", "2,50", "a", "lemon")]
        [InlineData("а", "2,50", "2,50", "lemon")]
        [InlineData("1", "2,50", "2,50", "le")]
        [InlineData("1", "", "2,50", "lemon")]
        [InlineData("1", "2,50", "", "lemon")]
        [InlineData("", "2,50", "2,50", "lemon")]
        public void ProductValidation_ShouldFail(string productQuantity, string productPrice, string deliveryPrice, string productName)
        {
            //Arrange
            bool expected = false;

            //Act
            bool actual = psf.ProductValidation(productQuantity, productPrice, deliveryPrice, productName);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
