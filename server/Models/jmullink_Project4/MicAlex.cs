using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardTest.Models.JmullinkProject4
{
  [Table("micAlex")]
  public partial class MicAlex
  {
    public int ID
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public DateTime Timestamp
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string Naam
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string Locatie
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public int Decibel
    {
      get;
      set;
    }
  }
}
