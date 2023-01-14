using System.Text.Json.Nodes;
using Microsoft.Extensions.Logging;

namespace lab_2;

public class Friend
{
    private static Contender currentBest = new Contender(0,"");
    
    
    private readonly ILogger _logger;
    
    private List<Contender> _contenders;
    private Friend _friend; 
    public Friend(ILogger<Friend> logger)
    {
        _logger = logger;
        _contenders = new List<Contender>();
    }
    
    public void AddContender(Contender contender, int flag)
    {
        _contenders.Add(contender);
        if (flag == 1)
        {
            if (currentBest.getRate < contender.getRate)
            {
                currentBest = contender;
            }
        }
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Friend started.");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Friend stopped.");
    }
    public bool Advicing()
    {
        return (_contenders.Last().getRate > currentBest.getRate);
    }
}