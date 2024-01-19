using System;
using System.Threading.Tasks;

namespace ExampleProject;

public static class AsyncMethod
{
    public static async Task<int> DoAsync()
    {
        await Task.Delay(TimeSpan.Zero);
        return 1;
    }

    public static int DoNonAsync()
    {
        return 1;
    }
}
