using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;
using Microsoft.AspNetCore.Http;

namespace ToDoApp.Services
{
    public class Repository
    {
        public static Dictionary<int, Status> status = new Dictionary<int, Status>
        {
            { 1, new Status { Id = 1, Value = "Not Started" } },
            { 2, new Status { Id = 2, Value = "In Progress" } },
            { 3, new Status { Id = 3, Value = "Done" } }
        };

        public static List<ToDo> list = new List<ToDo>
        {
            new ToDo { Id = 1, Title = "My First ToDo", Description = "Get the app working", Status = status[2] }
        };

        public static ToDo GetTodoById(int id)
        {
            var todo = list.SingleOrDefault(t => t.Id == id);
            return todo;
        }

        public static List<ToDo> SaveTodo(int id, IFormCollection collection)
        {
            //get current todo based on id

            //overwrite each property with values from collection

            //return same todo

            list.Where(t1 => t1.Id == id).ToList().ForEach(t2 => t2.Title = collection["Title"]);
            list.Where(t3 => t3.Id == id).ToList().ForEach(t4 => t4.Description = collection["Description"]);
            list.Where(t5 => t5.Id == id).ToList().ForEach(t6 => t6.Status = status[2]);

            return list;
        }

        public static void CreateTodo(IFormCollection collection)
        {
            //no need to get anything from list

            //create new object (Todo) and append values from collection

            //once new object is created, add new todo from the list.

            ToDo newTodo = new ToDo()
            {
                Id = Convert.ToInt32(collection["Id"]),
                Title = collection["Title"],
                Description = collection["Description"],
                Status = status[1]
            };

            list.Add(newTodo);
        }

        public static void DeleteTodo(int id)
        {
            //Find todo by Id
            var DeleteTodo = list.SingleOrDefault(t => t.Id == id);
            //Delete from list
            list.Remove(DeleteTodo);

        }
    }
}
