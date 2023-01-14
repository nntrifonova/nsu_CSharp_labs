using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace lab_2;


public class Hall
{
 private readonly ILogger _logger;
    
 private List<Contender> _contenders;
 private Friend _friend; 
 public Hall(ILogger<Hall> logger)
 {
  _logger = logger;
 }

 public int CurrentContender { get; set; }

 public void InitContenders(ContenderGenerator contenderGenerator, int contenderCount)
 {
  contenderGenerator.CreateContenders();
  contenderGenerator.Shuffle(contenderGenerator.princes);
  contenderGenerator.Shuffle(contenderGenerator.rating);
  _contenders = contenderGenerator.InviteAllGuests();
 }

 public void CallNextContender(int flag)
 {
  ++CurrentContender;
  _friend.AddContender(_contenders[CurrentContender], flag);
 }

 public void InitFriend(Friend friend)
 {
  _friend = friend;
 }

 public int ChoseCurrentHusband()
 {
  return _contenders[CurrentContender].getRate;
 }
}