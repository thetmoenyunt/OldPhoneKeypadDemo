namespace OldPhoneKeypadDemo.Tests
{
    /// <summary>
    /// Test class for Old Phone Keypad  
    /// </summary>
    public class KeypadTest
    {
        /// <summary>
        /// Test method for conversion from numberic keys to alphabetic letters
        /// </summary>
        /// <param name="input">Numeric Keys sequence</param>
        /// <param name="expected">Expected result after conversion</param>
        [Theory]
        [InlineData("227*#", "B")]
        [InlineData("8 88777444666*664#", "TURING")]
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

        /// <summary>
        /// Test method for input validation
        /// </summary>
        /// <param name="input">Input text of Numeric Keys sequence</param>
        /// <param name="expected">Expected result whether the input is valid or not</param>
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