using SYSCKM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SYSCKM.Services
{
    public class ColaboradorManager
    {
		IRestService<Colaborador> restService;

		public ColaboradorManager(IRestService<Colaborador> service)
		{
			restService = service;
		}

		public Task<List<Colaborador>> GetTasksAsync()
		{
			return restService.RefreshDataAsync();
		}

		public Task SaveTaskAsync(Colaborador item, bool isNewItem = false)
		{
			return restService.SaveTodoItemAsync(item, isNewItem);
		}

		public Task DeleteTaskAsync(Colaborador item)
		{
			return restService.DeleteTodoItemAsync(item.Cod_Funcionario);
		}
	}
}
