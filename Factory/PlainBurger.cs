using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


public class PlainBurger : IBurger
{
    public string getBun()
    {
        return "wheat";
    }

    public string getPatty()
    {
        return "beef";
    }

    
}