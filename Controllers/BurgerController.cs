using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BurgerController : ControllerBase
    {
        
        [HttpGet]
        public List<Burger> Get(string burgerType="plain")
        {
            BurgerFactory burgerFactory = new BurgerFactory();
            IBurger burger = burgerFactory.getBurger(burgerType);
            List<Burger> returnedBurger = new List<Burger>();
            returnedBurger.Add(new Burger{patty =burger.getPatty()
            ,bun= burger.getBun()});
           
            return returnedBurger;
           
        }
    }
}
