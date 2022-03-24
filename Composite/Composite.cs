
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI
{
    public class Composite : IComponent
    {

     string part;

     public Composite(string part)
     {
          this.part = part;
     }


        List<IComponent> components = new List<IComponent>();

        
        public  string getPart()
        { 
            string value=null;

           for(int i=0; i < components.Count; i++)
           {
               value = components.ElementAt(i).getPart();
           }

           return value;
        }

        public void addPart(IComponent component)
        {
            components.Add(component);
        }

        public void removePart (IComponent component)
        {
            components.Remove(component);
        }
    }
}