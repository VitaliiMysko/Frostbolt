using ConsoleRestaurant.Domain.Sets;
using System;

namespace ConsoleRestaurant.Domain.Entities
{
    public class Report
    {
        private string _message;

        public Command Command { get; set; }
        public bool CommandSucceeded { get; set; }
        public string CommandEntered { get; set; }

        public string Message { get => _message; }

        public void AddMessage(string message)
        {
            message = message.Trim();

            if (!string.IsNullOrEmpty(message))
            {
                _message += string.IsNullOrEmpty(_message) ? message : "\n" + message;
            }
        }

        public void ClearMessage(string message)
        {
            _message = "";
        }

        public string Result
        {
            get
            {
                if (String.IsNullOrEmpty(Message))
                {
                    return "**No message**";
                }

                return Message;
            }
        }

    }
}
