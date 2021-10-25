using System;
using Todo.Domain.Commands.Contracts;
using Flunt.Notifications;
using Todo.Domain.Entities;
using Flunt.Validations;

namespace Todo.Domain.Commands
{
    public class MarkTodoAsUndoneCommand : Notifiable<Notification>, ICommand
    {
        public MarkTodoAsUndoneCommand() { }

        public MarkTodoAsUndoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id { get; set; }
        public string User { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<MarkTodoAsUndoneCommand>()
                    .Requires()
                    .IsGreaterOrEqualsThan(User, 6, "User", "Usuário inválido!")
            );
        }
    }
}