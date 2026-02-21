using NUnit.Framework;

namespace TestApp.Tests;

public class PasswordValidatorTests
{
    [Test]
    public void Test_CheckPassword_ValidPassword_ReturnsValidMessage()
    {
        string validPass = "Pass123";
        string expected = "Password is valid";

        string actual = PasswordValidator.CheckPassword(validPass);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_PasswordTooShort_ReturnsErrorMessage()
    {
        string invalidPass = "Short";
        string expected = "Password must be between 6 and 10 characters";

        string actual = PasswordValidator.CheckPassword(invalidPass);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_ContainsSpecialCharacters_ReturnsErrorMessage()
    {
        string invalidPass = "Inv@Pass";
        string expected = "Password must consist only of letters and digits";

        string actual = PasswordValidator.CheckPassword(invalidPass);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_InsufficientDigits_ReturnsErrorMessage()
    {
        string empty = "NoDigits";
        string expected = "Password must have at least 2 digits";

        string actual = PasswordValidator.CheckPassword(empty);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_ValidPasswordWithMaximumLength_ReturnsValidMessage()
    {
        string validPassMaxLength = "ValPass123";
        string expected = "Password is valid";

        string actual = PasswordValidator.CheckPassword(validPassMaxLength);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
