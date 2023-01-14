using System.ComponentModel.Design;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace lab_2;

public class Princess : BackgroundService
{
    private readonly ILogger<Princess> _logger;

    private const int ContenderCount = 100;
    private Hall _hall;
    private Friend _friend;

    private int nobody = -1;

    private IServiceProvider Services { get; }

    public Princess(ILogger<Princess> logger, IServiceProvider services)
    {
        _logger = logger;
        Services = services;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Princess running at: {time}", DateTimeOffset.Now);
        using (var scope = Services.CreateScope())
        {
            _hall = scope.ServiceProvider.GetRequiredService<Hall>();
            _friend = scope.ServiceProvider.GetRequiredService<Friend>();
            var contenderGenerator = scope.ServiceProvider.GetRequiredService<ContenderGenerator>();

            _hall.InitContenders(contenderGenerator, ContenderCount);
            _hall.InitFriend(_friend);
        }

        var happyLevel = ChoseHusband();
        if (happyLevel > 50)
        {
            Console.WriteLine($"Happy level = {happyLevel}"); 
        }
        else if (happyLevel == -1)
        {
            Console.WriteLine($"Happy level = 10");
        }
        else
        {
            Console.WriteLine($"Happy level = 0");
        }
        Environment.Exit(0);
    }

    private int ChoseHusband()
    {
        while (_hall.CurrentContender != 5)
        {
            _hall.CallNextContender(1);
        }

        while (_hall.CurrentContender != ContenderCount)
        {
            _hall.CallNextContender(0);
            var friendAnswer = _friend.Advicing();
            if (friendAnswer)
            {
                return _hall.ChoseCurrentHusband();
            }
        }

        return nobody;
    }
}

