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
    public class LabelControllerTests
    {
        Label label = new Label();

        [Fact]
        public void ChangeLabelVisibility_ShouldChangeToTrue()
        {
            //Arrange
            bool expected = true;

            //Act
            bool actual = LabelController.ChangeLabelVisibility(ref label, true);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ChangeLabelVisibility_ShouldChangeToFalse()
        {
            //Arrange
            bool expected = false;

            //Act
            bool actual = LabelController.ChangeLabelVisibility(ref label, false);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ChangeLabelText_ShouldChangeText()
        {
            //Arrange
            string expected = "label text changed";

            //Act
            string actual = LabelController.ChangeLabelText(ref label, "label text changed");

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
