using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using Todo.Domain.Entities;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class TodoItemTests
    {
        private readonly TodoItem _validTodo = new TodoItem("Titulo", "matheus", DateTime.Now);

        [TestMethod]
        public void Dado_um_novo_todo_este_nao_pode_ser_concluido()
        {
            Assert.AreEqual(_validTodo.Done, false);
        }

    }
}
