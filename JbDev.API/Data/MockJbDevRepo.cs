﻿using JbDev.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JbDev.API.Data
{
    public class MockJbDevRepo : IJbDevRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan"},
                new Command {Id = 1, HowTo = "Cut bread", Line = "Get a knife", Platform = "Knife & Chopping Board"},
                new Command {Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform = "Kettle & Cup"}


            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan"};
        }
    }
}
