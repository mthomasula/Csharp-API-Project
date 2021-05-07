using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo //Fake Data Store for now
    {

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Change directory", Line="cd", Platform="Mac OS"},
                new Command{Id=1, HowTo="Create folder", Line="mkdir", Platform="Mac OS"},
                new Command{Id=2, HowTo="Create file", Line="touch", Platform="Mac OS"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Change directory", Line="cd", Platform="Mac OS"};
        }


    }
}