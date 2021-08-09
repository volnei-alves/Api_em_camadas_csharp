using Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositorios
{
    public interface IUser
    {
        Task<int> Adicionar(User user);
        Task<List<User>> GetAll();
        Task<User> GetById(int id);
    }
}
