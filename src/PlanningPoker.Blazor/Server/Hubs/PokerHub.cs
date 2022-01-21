﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace PlanningPoker.Blazor.Server.Hubs;

public class PokerHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}