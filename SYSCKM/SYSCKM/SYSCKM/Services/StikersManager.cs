using SYSCKM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SYSCKM.Services
{    
    public class StikersManager
    {
        IStikersService<Stikers> restService;
        public StikersManager(IStikersService<Stikers> service)
        {
            restService = service;
        }
        public Task<List<Stikers>> GetTasksAsync(Stikers stikers)
        {
            return restService.getall(stikers);
        }
    }
}
