using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Todo.Database.Models;
using Todo.Database.Resources;
using Todo.Domain.Interfaces;
using Todo.Domain.Models.Item;

namespace Todo.Domain.Services
{
    public class ItemService : IItemService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public ItemService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<ItemModel>> GetAll()
        {
            var result = await _context.Items.ToListAsync();
            var results = _mapper.Map<List<Item>, List<ItemModel>>(result);
            return results;
        }

        /// <inheritdoc/>
        public async Task<ItemModel> Get(Guid guid)
        {
            var item = await _context.Items.FirstOrDefaultAsync(a => a.Guid == guid);
            var itemModel = _mapper.Map<ItemModel>(item);
            return itemModel;
        }

        /// <inheritdoc/>
        public async Task<Guid> Create(ItemModel itemModel)
        {
            var item = _mapper.Map<Item>(itemModel);
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
            return item.Guid;
        }

        /// <inheritdoc/>
        public async Task<Guid> Update(ItemModel itemModel)
        {
            var item = _mapper.Map<Item>(itemModel);
            _context.Items.Update(item);
            await _context.SaveChangesAsync();
            return item.Guid;
        }

        /// <inheritdoc/>
        public async Task Delete(Guid guid)
        {
            var item = await _context.Items.FindAsync(guid);
            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}