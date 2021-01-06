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
    public class TextBoxControllerTests
    {
        TextBox textbox1 = new TextBox();
        TextBox textbox2 = new TextBox();
        TextBox textbox3 = new TextBox();

        [Fact]
        public void ChangeTextBoxText_ShouldChangeText()
        {
            //Arrange
            bool expected = true;

            //Act
            TextBoxController.ChangeTextBoxText(ref textbox1, "new text");
            bool actual = textbox1.Text == "new text";

            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ChangeThreeTextBoxesText_ShouldChangeThreeTextBoxesText()
        {
            //Arrange
            bool expected = true;

            //Act
            TextBoxController.ChangeThreeTextBoxesText(ref textbox1, ref textbox2, ref textbox3, "new text1", "new text2", "new text3");
            bool actual = (textbox1.Text == "new text1" && textbox2.Text == "new text2" && textbox3.Text == "new text3");

            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
