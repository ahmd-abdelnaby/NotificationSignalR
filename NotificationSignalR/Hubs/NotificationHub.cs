using Hangfire;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNetCore.SignalR;
using System.Threading;
using System.Threading.Tasks;

namespace NotificationSignalR.Hubs
{
    [HubName("notificationHub")]
    public class NotificationHub : Hub
    {
        public NotificationHub()
        {
        }
        [Microsoft.AspNet.SignalR.Hubs.HubMethodName("SendNotification")]
        public void SendMessage()
        {
            // await Clients.All.SendAsync("SendNotification", CancellationToken.None);
            Clients.All.SendAsync("SendNotification");
        }
    }
}
