using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Todo.Database.Models;
using Todo.Database.Resources;
using Todo.Domain.Interfaces;
using Todo.Domain.Models.User;

namespace Todo.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public UserService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        /// <inheritdoc/>
        public async Task<IEnumerable<UserModel>> GetAll()
        {
            var result = await _context.Users.ToListAsync();
            var results = _mapper.Map<List<User>, List<UserModel>>(result);
          
            return results;
        }

        /// <inheritdoc/>
        public async Task<UserModel> Get(string id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(a=>a.Id==id);
            var userModel = _mapper.Map<UserModel>(user);
           
            return userModel;
        }

        /// <inheritdoc/>
        public async Task<string> Create(UserModel userModel)
        {
            var user = _mapper.Map<User>(userModel);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user.Id;
        }

        public async Task<string> Update(UserModel userModel)
        {
            var user = _mapper.Map<User>(userModel);
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user.Id;
        }

        public async Task Delete(string id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}