using System.Threading.Tasks;
using Todo.Domain.Models.Register;

namespace Todo.Domain.Interfaces
{
    public interface IRegisterService
    {
        Task<string> Register(RegisterFullModel registerFullModel);
    }
}