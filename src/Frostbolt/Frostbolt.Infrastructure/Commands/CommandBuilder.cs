using ConsoleRestaurant.Domain.Interfaces;
using ConsoleRestaurant.Domain.Sets;
using Frostbolt.Infrastructure.Commands;
using System;
using System.Linq;

namespace ConsoleRestaurant.Infrastructure.Commands
{
    public class CommandBuilder
    {
        private readonly string _action;
        private readonly string[] _dataArr;
        public CommandBuilder(string[] dataArrFull)
        {
            _action = dataArrFull[0];
            _dataArr = dataArrFull.Where((item, idx) => idx != 0).ToArray();
        }

        public ICommand Build()
        {

            switch (_action)
            {
                case nameof(Command.Equip):

                    return new EquipCommand(_dataArr);

                case nameof(Command.Press):

                    return new PressCommand(_dataArr);

                case nameof(Command.Setbutton):

                    return new SetbuttonCommand(_dataArr);

                case nameof(Command.Setgem):

                    return new SetgemCommand(_dataArr);

                default:

                    throw new Exception($"Error! Command \"{_action}\" is not correct");
            }

        }
    }
}