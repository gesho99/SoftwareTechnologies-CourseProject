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

        [Fact]
        public void ChangeLabelVisibility_ShouldChangeToTrue()
        {
            //Arrange
            bool expected = true;

            //Act
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
            bool actual = psf.ChangeLabelVisibility(new Label(), false);

            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void ChangeLabelText_ShouldChangeText()
        {
            //Arrange
            string expected = "label text changed";

            //Act
            string actual = psf.ChangeLabelText(new Label(), "label text changed");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddProductAsItem_ShouldAddProduct()
        {
            //Arrange
            bool expected = true;

            //Act
            ListBox lb = psf.AddProductAsItem("tomatoes");
            bool actual = lb.Items.Contains("tomatoes");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddProductParameters_ShouldAddParameters()
        {
            //Arrange
            bool expected = true;

            //Act
            ListBox lb = psf.AddProductParameters(10, 5.60, 5.60);
            bool actual = lb.Items.Contains(10 + " " + 5.60 + " " + 5.60);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
