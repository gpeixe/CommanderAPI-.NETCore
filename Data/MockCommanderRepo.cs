using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{

    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command{Id=0, HowTo="Make a Cake", Line="3 Eggs", Plataform="Cake Shop"},
                new Command{Id=1, HowTo="Cut a hair", Line="Get scissors and use", Plataform="Barbershop"},
                new Command{Id=2, HowTo="Be Happy", Line="Get Seretonin into your brain", Plataform="Psycho"},
                new Command{Id=3, HowTo="Make a dir", Line="Use de command mkdir [dir's name]", Plataform="Windows and Linux"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=3, HowTo="Make a dir", Line="Use de command mkdir [dir's name]", Plataform="Windows and Linux"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            //throw new System.NotImplementedException();
        }
    }
}