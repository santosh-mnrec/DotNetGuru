using Microsoft.AspNetCore.Components;

namespace DotNetGuru.Events
{
    public class EventBase : ComponentBase
    {

        public static EventHandler<UserEventArgs> OnUserChanged;
        public static EventHandler ResetUserChanged;

        public void UserChanged(string username)
        {
            OnUserChanged?.Invoke(this, new UserEventArgs() { Name = username });
        }
        public void UnSubscribe()
        {
            ResetUserChanged?.Invoke(this, null);
        }

    }
}
