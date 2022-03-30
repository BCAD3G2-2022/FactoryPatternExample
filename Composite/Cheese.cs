using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI 
{
    public class Cheese: IComponent
    {
        
        public string getBurgerPart()
        {
            return "cheese";
        }
    }
}
