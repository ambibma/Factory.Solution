namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId {get;set;}

    //public DateTime HireDate{get;set;}
    public string Name {get;set;}

    public List<MachineEngineer> JoinEntities{get;set;}

  }
}