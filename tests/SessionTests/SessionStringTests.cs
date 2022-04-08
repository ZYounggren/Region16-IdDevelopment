using Xunit;
using domain;
using Xunit.Abstractions;

namespace tests.SessionTests;

public class SessionStringTest
{
    //Check whether a string input matches existing string.
    [Fact]
    public void TestStringInputIsEqual()
    {
        //Arrange
        string mockTitle = "Physics";

        //Act
        Session mockSession = new Session();
        mockSession.SessionTitle = "Physics";

        //Assert
        Assert.Equal(mockSession.SessionTitle, mockTitle);
    }
}