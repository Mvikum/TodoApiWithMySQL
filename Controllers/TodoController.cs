using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;


namespace ToDoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private static readonly List<TodoItem> Todos = new List<TodoItem>
        {
            new TodoItem { Id = 1, Name = "Learn ASP.NET", IsComplete = false },
            new TodoItem { Id = 2, Name = "Build Web API", IsComplete = false }
        };

        //Get All Data
        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> GetTodos()
        {
            return Ok(Todos);
        }

        //Post create a new TodoItem
        [HttpPost]
        public ActionResult<TodoItem> CreateTodo(TodoItem todo)
        {
            todo.Id = Todos.Max(t => t.Id) + 1;
            Todos.Add(todo);
            return CreatedAtAction(nameof(GetTodos), new { id = todo.Id }, todo);
        }

        //PUT update an existing item
        [HttpPut("{id}")]
        public IActionResult UpdateTodo(int id, TodoItem todo)
        {
            var existingTodo = Todos.FirstOrDefault(t => t.Id == id);
            if (existingTodo == null) return NotFound();

            existingTodo.Name = todo.Name;
            existingTodo.IsComplete = todo.IsComplete;
            return NoContent();
        }

        //DELETE delete an existing item
        [HttpDelete("{id}")]
        public IActionResult DeleteTodo(int id)
        {
            var existingTodo = Todos.FirstOrDefault(t => t.Id == id);
            if (existingTodo == null) return NotFound();

            Todos.Remove(existingTodo);
            return NoContent();
        }


    }
}