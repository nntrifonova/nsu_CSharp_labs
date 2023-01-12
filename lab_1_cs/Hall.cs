using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace lab_1_cs;


public class Hall
{
 private int index;
 private List<string> names;
 private List<int> rates;
 

 public Hall(List<string> names, List<int> rates)
 {
  this.index = -1;
  this.names = names;
  this.rates = rates;
 }

 public static Contender CreateContender(string name, int rate)
 {
  var prince = new Contender(rate, name);
  return prince;
 }
 
 public Contender CallNext
 {
  get
  {
   index++;
   return CreateContender(this.names[index],this.rates[index]);
  }
 }
 /*public static void GetNextPrince (List<string> names, List<int> rates)
 {
  names.RemoveAt(0);  //убрать, чтоб не тянуть списки. Подумать как реализовать главный цикл.
  rates.RemoveAt(0);
 }*/
}