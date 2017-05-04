﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SerproApp.Services.WebService
{
    public interface IRestService<T>
    {
        Task<List<T>> RefreshDataAsync();

        Task SaveTodoItemAsync(T item, bool isNewItem);

        Task DeleteTodoItemAsync(string id);
    }
}
