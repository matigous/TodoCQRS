using System;
using Todo.Domain.Commands.Contracts;
using Flunt.Notifications;
using Todo.Domain.Entities;
using Flunt.Validations;

namespace Todo.Domain.Commands
{
    public class MarkTodoAsDoneCommand : Notifiable<Notification>, ICommand
    {
        public MarkTodoAsDoneCommand() { }

        public MarkTodoAsDoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id { get; set; }
        public string User { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<MarkTodoAsDoneCommand>()
                    .Requires()
                    .IsGreaterOrEqualsThan(User, 6, "User", "Usuário inválido!")
            );
        }
    }
}