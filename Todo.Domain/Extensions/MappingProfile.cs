using AutoMapper;
using Todo.Database.Models;
using Todo.Domain.Models.Item;
using Todo.Domain.Models.Register;
using Todo.Domain.Models.User;

namespace Todo.Domain.Extensions
{
    /// <summary>
    /// Конфигурация automapper
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary/>
        public MappingProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<UserModel, User>();

            CreateMap<Item, ItemModel>();
            CreateMap<ItemModel, Item>();

            CreateMap<User, RegisterFullModel>();
            CreateMap<RegisterFullModel, User>();
        }
    }
}