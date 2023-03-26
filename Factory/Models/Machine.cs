
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId {get;set;}
    [Required(ErrorMessage = "This Machines Name cannot be empty!")]
    public string Name {get;set;}
    public List<EngineerMachine> JoinEntities{get;set;}
    //public DateTime InstallDate{get;set;}

  }
}