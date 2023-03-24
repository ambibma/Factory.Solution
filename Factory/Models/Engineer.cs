using System;
using System.Linq;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId {get;set;}

    //public DateTime HireDate{get;set;}
    public string Name {get;set;}

    public List<EngineerMachine> JoinEntities{get;set;}

  }
}