using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands=new List<Command>
            {
                new Command{Id=0, HowTo="Get depression", Line="Be Vuko", Platform="You"},
                new Command{Id=1, HowTo="Cry efficiently", Line="Go to college", Platform="Your face"},
                new Command{Id=2, HowTo="Waste your life", Line="Go to college", Platform="College"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Get depression", Line="Be Vuko", Platform="Your head"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}