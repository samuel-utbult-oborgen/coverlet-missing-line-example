using Xunit;

namespace ExampleProject.Tests;

public class InheritedRecordTests
{
    [Fact]
    public void Constructor()
    {
        var inheritedRecord = new InheritedRecord(1);
        Assert.Equal(1, inheritedRecord.A);
    }
}
