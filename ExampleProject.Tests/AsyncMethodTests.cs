using System.Threading.Tasks;
using Xunit;

namespace ExampleProject.Tests;

public class AsyncMethodTests
{
    [Fact]
    public async Task DoAsync_WhenCalled_Returns1()
    {
        Assert.Equal(1, await AsyncMethod.DoAsync());
    }

    [Fact]
    public void DoNonAsync_WhenCalled_Returns1()
    {
        Assert.Equal(1, AsyncMethod.DoNonAsync());
    }
}
