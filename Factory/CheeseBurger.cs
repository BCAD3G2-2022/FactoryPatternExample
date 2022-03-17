using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

public class CheeseBurger : IBurger
{
    public string getBun()
    {
        return "Rye";
    }

    public string getPatty()
    {
        return "beef";
    }

    public string getCheese()
    {
        return "cheese";
    }
}