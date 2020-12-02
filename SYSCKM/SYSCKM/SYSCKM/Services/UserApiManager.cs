using SYSCKM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SYSCKM.Services
{
    public class UserApiManager
    {
		IRestService<UsersApi> restService;

		public UserApiManager(IRestService<UsersApi> service)
		{
			restService = service;
		}

		public Task<List<UsersApi>> GetTasksAsync()
		{
			return restService.RefreshDataAsync();
		}

		public Task SaveTaskAsync(UsersApi item, bool isNewItem = false)
		{
			return restService.SaveTodoItemAsync(item, isNewItem);
		}

		public Task DeleteTaskAsync(UsersApi item)
		{
			return restService.DeleteTodoItemAsync(item.Id);
		}
	}
}
