using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.Tests;

public class MessagingTests
{
    [Test]
    public void Test_GetMessage_WithValidInput_ReturnsExpectedMessage()
    {
        List<int> validInput = new() { 1, 2, 3 };
        string text = "Hello";

        string expected = "elH";


        string actual = Messaging.GetMessage(validInput, text);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMessage_EmptyList_ReturnsEmptyString()
    {
        List<int> emptyList = new() {};
        string text = "Hello";

        string actual = Messaging.GetMessage(emptyList, text);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GetMessage_EmptyString_ReturnsEmptyString()
    {
        List<int> emptyList = new() { 1, 2, 3 };
        string text = "";

        string actual = Messaging.GetMessage(emptyList, text);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GetMessage_NullList_ReturnsEmptyString()
    {
        List<int> emptyList = null;
        string text = "Hi";

        string actual = Messaging.GetMessage(emptyList, text);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GetMessage_NullString_ReturnsEmptyString()
    {
        List<int> emptyList = new() { 1, 2, 3 };
        string text = null;

        string actual = Messaging.GetMessage(emptyList, text);

        Assert.That(actual, Is.Empty);
    }
}
