using Microsoft.AspNetCore.SignalR;

namespace PlanningPoker.Blazor.Server.Hubs;

public class PokerHub : Hub
{
  public async Task SendMessage(string user, string message, string groupName)
  {
    await Clients.Group(groupName).SendAsync("ReceiveMessage", user, message);
  }

  public async Task AddToGroup(string groupName)
  {
    await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
  }

  public async Task ShowResults(string groupName)
  {
    await Clients.Group(groupName).SendAsync("ShowResults");
  }

  public async Task Reset(string groupName)
  {
    await Clients.Group(groupName).SendAsync("Reset");
  }
}
