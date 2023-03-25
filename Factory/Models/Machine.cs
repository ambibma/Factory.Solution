using System;
using System.Linq;
using System.Collections.Generic;
using Factory.Models;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId {get;set;}
    //public DateTime InstallDate{get;set;}
    public string Name {get;set;}
    public List<EngineerMachine> JoinEntities{get;set;}

  }
}