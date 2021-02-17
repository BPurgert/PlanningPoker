using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using PlanningPoker.API.Models;

namespace PlanningPoker.API.Hubs
{
  public class VoteHub : Hub
  {
    public VoteHub()
    {

    }

    public async Task SendVote(VoteMessage message)
    {
      await Clients.All.SendAsync("ReceiveVote", message);
    }
  }
}
