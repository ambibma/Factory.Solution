using System;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId {get;set;}
    //public DateTime InstallDate{get;set;}
    public string Name {get;set;}
    public List<MachineEngineer> JoinEntities{get;set;}

  }
}