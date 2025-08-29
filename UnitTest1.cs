using Xunit;
using ClassLibrary1;

namespace PasswordChecker1
{
    public class PasswordCheckerTests
    {
        [Fact]
        public void EmptyPassword_ReturnsIneligible()
        {
            Assert.Equal("INELIGIBLE", PasswordChecker.CheckStrength(""));
        }

        [Fact]
        public void OnlyUppercase_ReturnsWeak()
        {
            Assert.Equal("WEAK", PasswordChecker.CheckStrength("ABC"));
        }

        [Fact]
        public void OnlyLowercase_ReturnsWeak()
        {
            Assert.Equal("WEAK", PasswordChecker.CheckStrength("abc"));
        }

        [Fact]
        public void OnlyDigits_ReturnsWeak()
        {
            Assert.Equal("WEAK", PasswordChecker.CheckStrength("12345"));
        }

        [Fact]
        public void OnlySymbols_ReturnsWeak()
        {
            Assert.Equal("WEAK", PasswordChecker.CheckStrength("@#$"));
        }

        [Fact]
        public void UppercaseAndLowercase_ReturnsMedium()
        {
            Assert.Equal("MEDIUM", PasswordChecker.CheckStrength("Abc"));
        }

        [Fact]
        public void LowercaseAndDigit_ReturnsMedium()
        {
            Assert.Equal("MEDIUM", PasswordChecker.CheckStrength("abc1"));
        }

        [Fact]
        public void DigitAndSymbol_ReturnsMedium()
        {
            Assert.Equal("MEDIUM", PasswordChecker.CheckStrength("1@"));
        }

        [Fact]
        public void UpperLowerDigit_ReturnsMedium()
        {
            Assert.Equal("MEDIUM", PasswordChecker.CheckStrength("Ab1"));
        }

        [Fact]
        public void StrongPassword_ReturnsStrong()
        {
            Assert.Equal("STRONG", PasswordChecker.CheckStrength("Ab1@"));
        }
    }
}
