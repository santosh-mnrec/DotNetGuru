using Microsoft.AspNetCore.Components;

namespace DotNetGuru.Events; 

public class DotNetGuruEventArgs : EventArgs
{
    public bool IsMedia { get; set; }
    public string Data { get; set; }
}

[EventHandler("ondotnetguruevent", typeof(DotNetGuruEventArgs), true, true)]
public static class EventHandlers
{
}