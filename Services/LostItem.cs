using LostFound.Modals;
using LostFound.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostFound.Services
{
    public class LostItem : ILostItem
    {
        private UserContext _usercontext;
        public LostItem(UserContext usercontext)
        {
            _usercontext = usercontext;
        }

        public LostIItems AddLostItem(LostIItems item)
        {
            _usercontext.Lost.Add(item);
            return item;
        }

        public LostIItems DeleteLostItem(LostIItems item)
        {
            throw new NotImplementedException();
        }

        public LostIItems GetLostItem(Guid id)
        {

            throw new NotImplementedException();
        }

        public List<LostIItems> GetLostItems()
        {
            throw new NotImplementedException();
        }

        public LostIItems UpdateLostItem(LostIItems item)
        {

            _usercontext.Lost.Add(item);
            return item;
        }
    }
}
