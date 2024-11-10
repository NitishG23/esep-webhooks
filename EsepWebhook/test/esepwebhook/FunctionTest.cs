using Xunit;
using Amazon.Lambda.TestUtilities;

namespace EsepWebhook.Tests;

public class FunctionTest
{
    [Fact]
    public void TestToUpperFunction()
    {
        // Arrange
        var function = new Function();
        var context = new TestLambdaContext();
        
        // Act
        var result = function.FunctionHandler("hello world", context);

        // Assert
        Assert.Equal("HELLO WORLD", result);
    }
}
