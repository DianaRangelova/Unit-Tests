using System;

using NUnit.Framework;

using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        //Arrange
        //Създаване на чат стая, която я има в setup
        string sender = "Diana";
        string message = "Have fun!";

        //Act
        _chatRoom.SendMessage(sender, message);
        string actualResult = _chatRoom.DisplayChat();

        //Assert
        Assert.That(actualResult, Does.Contain("Chat Room Messages:"));
        Assert.That(actualResult, Does.Contain("Diana: Have fun! - Sent at "));
        //Assert.That(actualResult, Does.Contain(DateTime.Now.Date.ToString("d")));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        //Arrange
        //Създаване на чат стая, която я има в setup

        //Act
        string actualResult = _chatRoom.DisplayChat();

        //Assert
        Assert.That(actualResult, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        //Arrange
        //Създаване на чат стая, която я има в setup
        string firstSender = "Diana";
        string firstSendermessage = "Have fun!";
        string seondSender = "Ivan";
        string secondSendermessage = "Good luck on exam!";

        //Act
        _chatRoom.SendMessage(firstSender, firstSendermessage);
        _chatRoom.SendMessage(seondSender, secondSendermessage);
        string actualResult = _chatRoom.DisplayChat();

        //Assert
        Assert.That(actualResult, Does.Contain("Chat Room Messages"));
        Assert.That(actualResult, Does.Contain("Diana: Have fun! - Sent at"));
        Assert.That(actualResult, Does.Contain("Ivan: Good luck on exam! - Sent at"));
        //Assert.That(actualResult, Does.Contain(DateTime.Now.Date.ToString("d")));
    }
}
