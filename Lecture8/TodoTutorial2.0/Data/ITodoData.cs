﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TodoTutorial2._0.Models;

namespace TodoTutorial2._0.Data {
    public interface ITodoData {
        Task<IList<Todo>> GetTodosAsync();
        Task AddTodoAsync(Todo todo);
        Task RemoveTodoAsync(int todoId);
        Task UpdateAsync(Todo todo);
        Task<Todo> GetAsync(int id);
    }
}