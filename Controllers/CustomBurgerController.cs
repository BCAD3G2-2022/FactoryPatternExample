using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace BurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomBurgerController : ControllerBase
    {
        
        [HttpGet]
        public List<string> Get (bool tomato, bool cheese, 
        bool lettuce)
        {
            IComponent burgerBun = new Bun();
            IComponent burgerPatty = new Patty();
            IComponent burgerLettuce = new Lettuce();
            IComponent burgerTomato = new Tomato();
            IComponent burgerCheese= new Cheese();

          
           

           Composite BaseBurger = new Composite();
           BaseBurger.addBurgerParts(burgerBun);
           BaseBurger.addBurgerParts(burgerPatty);
           BaseBurger.addBurgerParts(burgerTomato);
           BaseBurger.addBurgerParts(burgerCheese);
           BaseBurger.addBurgerParts(burgerLettuce);

           
           if(!tomato)
           {
              BaseBurger.removeBurgerParts(burgerTomato); 
           }

           if(!lettuce)
           {
               BaseBurger.removeBurgerParts(burgerLettuce);
           }

           if (!cheese)
           {
               BaseBurger.removeBurgerParts(burgerCheese);
           }

           List<string> returnList = new List<string>();
           returnList.Add(BaseBurger.getBurgerPart());

           return returnList;
  
           
        }
    }
}
