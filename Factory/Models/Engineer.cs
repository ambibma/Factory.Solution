using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId {get;set;}
    [Required(ErrorMessage = "This Engineers Name cannot be empty!")]
    public string Name {get;set;}
     

    public List<EngineerMachine> JoinEntities{get;set;}
    //public DateTime HireDate{get;set;}

  }
}