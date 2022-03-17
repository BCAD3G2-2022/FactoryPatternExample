using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI
{
  public class Burger
  {

      public string patty { get; set; }
      public string bun { get; set; }
      public string extras { get; set; }
     
      

  }

}