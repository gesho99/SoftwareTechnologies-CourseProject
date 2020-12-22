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
        [Fact]
        public void ChangeLabelVisibility_ShouldChangeToTrue()
        {
            //Arrange
            bool expected = true;

            //Act
            ProductsInStockForm psf = new ProductsInStockForm();
            bool actual = psf.ChangeLabelVisibility(new Label(), true);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ChangeLabelVisibility_ShouldChangeToFalse()
        {
            //Arrange
            bool expected = false;

            //Act
            ProductsInStockForm psf = new ProductsInStockForm();
            bool actual = psf.ChangeLabelVisibility(new Label(), false);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
