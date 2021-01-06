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
    public class ListBoxControllerTests
    {

        ListBox listbox = new ListBox();

        [Fact]
        public void AddItemsInListBox_ShouldAddProduct()
        {
            //Arrange
            bool expected = true;

            //Act
            ListBoxController.AddListBoxItems(ref listbox, "tomatoes");
            bool actual = listbox.Items.Contains("tomatoes");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddParametersInListBox_ShouldAddParameters_FirstTest()
        {
            //Arrange
            bool expected = true;

            //Act
            ListBoxController.AddListBoxParameters(ref listbox, 10, 5.60, 5.60);
            bool actual = listbox.Items.Contains(10 + " " + 5.60 + " " + 5.60);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddParametersInListBox_ShouldAddParameters_SecondTest()
        {
            //Arrange
            bool expected = true;

            //Act
            ListBoxController.AddListBoxParameters(ref listbox, 5.60, "test", 5.60);
            bool actual = listbox.Items.Contains(5.60 + " test " + 5.60);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ClearItemsInListBox_ShouldClearItems()
        {
            //Arrange
            bool expected = true;

            //Act
            ListBoxController.ClearItems(ref listbox);
            bool actual = listbox.Items.Count == 0;

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
