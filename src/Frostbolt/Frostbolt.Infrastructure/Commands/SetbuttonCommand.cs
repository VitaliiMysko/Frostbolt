using ConsoleRestaurant.Domain.Entities;
using ConsoleRestaurant.Domain.Interfaces;
using ConsoleRestaurant.Domain.Sets;
using System;

namespace Frostbolt.Infrastructure.Commands
{
    public class SetbuttonCommand : ICommand
    {
        private readonly string[] _commandDataArr;
        private readonly string _commandEntered;

        public SetbuttonCommand(string[] dataArr)
        {
            _commandDataArr = dataArr;
            _commandEntered = nameof(Command.Equip) + ": " + String.Join(", ", _commandDataArr);
        }

        public Report Execute()
        {
            var report = new Report();
            report.Command = Command.Equip;
            report.CommandEntered = _commandEntered;

            //Bla bla bla
            //Bla bla bla
            //Bla bla bla
            //Bla bla bla

            return report;
        }
    }
}
