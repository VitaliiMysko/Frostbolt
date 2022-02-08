using ConsoleRestaurant.Domain.Entities;
using ConsoleRestaurant.Domain.Interfaces;
using ConsoleRestaurant.Infrastructure.Commands;
using ConsoleRestaurant.Infrastructure.Outputs;
using System;

namespace ConsoleRestaurant.Application
{
    public class Workflow
    {
        private readonly IOutput _outputApp;

        public Workflow()
        {
            _outputApp = new OutputApp();
        }

        public string[] GetData()
        {
            string actionFull = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(actionFull))
            {
                return null;
            }

            var dataArr =  Helper.ParseActionLine(actionFull);
            dataArr[0] = Helper.FirstCharToUpper(dataArr[0]);

            return dataArr;
        }

        public void Run()
        {
            

            // equip body tabula_rasa
            // setgem 1 icenova
            // setgem 2 gmp
            // setgem 3 frostbolt
            // setgem 4 spellecho
            // setgem 5 cd
            // setbutton mouse right frostbolt
            // setbutton key t frostbolt
            // setbutton key q icenova
            // press key t
            // press mouse right
            // press key q

            var dataArr = GetData();     // equip body tabula_rasa

            if (dataArr == null)
            {
                ToDisplay("Have you a nice day! Be.");
                return;
            }

            try
            {
                RunCommand(dataArr);
            }
            catch (Exception e)
            {
                ToDisplay(e.Message);

                if (e.Message == "Restaurant Bankrupt!")
                {
                    return;
                }
            }

            ToDisplay("");

            Run();
        }

        private void RunCommand(string[] dataArr)
        {
            var commandBuilder = new CommandBuilder(dataArr);
            var command = commandBuilder.Build();
            Report report = command.Execute();

            ShowResult(report);

        }

        private void ShowResult(Report report)
        {
            ToDisplay(report.Result);

        }

        private void ToDisplay(string message)
        {
            _outputApp.Print(message);
        }
    }
}
