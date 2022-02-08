using ConsoleRestaurant.Domain.Entities;

namespace ConsoleRestaurant.Domain.Interfaces
{
    public interface ICommand
    {
        public Report Execute();
    }
}
