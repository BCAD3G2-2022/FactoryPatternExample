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
    List<IComponent> components = new List<IComponent>();

        public void addBurgerParts(IComponent component)
        {
            components.Add(component);
        }
         


        public void removeBurgerParts(IComponent component)
        {
            components.Remove(component);
        }

        public string getBurgerPart()
        {
            string part = null;
            
            for(int i =0; i < components.Count;i++)
            {
                 part += components.ElementAt(i).getBurgerPart();
            }


            return part;


        }
    }
}