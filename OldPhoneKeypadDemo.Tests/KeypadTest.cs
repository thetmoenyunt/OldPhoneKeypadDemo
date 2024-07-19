namespace OldPhoneKeypadDemo.Tests
{
    public class KeypadTest
    {
        [Theory]
        [InlineData("227*#", "B")]
        [InlineData("8 88777444666*664#", "T URING")]
        [InlineData("77778866333555666933777#", "SUNFLOWER")]
        public void OldPhonePadTest(string input, string expected)
        {
            //Arrange
            //Multiple test cases with [Theory]

            //Act
            string actualResult = Keypad.OldPhonePad(input);

            //Assert
            Assert.Equal(expected, actualResult);
            
        }

        [Theory]
        [InlineData("33#", true)]
        [InlineData("33ABC#", false)]
        [InlineData("77778866333555666933777#", true)]
        [InlineData("77778866333555666933777", false)]
        public void IsValidInputTest(string input, bool expected)
        {
            //Arrange
            //Multiple test cases with [Theory]

            //Act
            bool actuallyValid = Keypad.IsValidInput(input);

            //Assert
            Assert.Equal(expected, actuallyValid);
        }
    }
}