using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SYSCKM.Services
{
    public interface IStikersService<T>
    {
        Task<List<T>> getall(T obj);
    }
}
