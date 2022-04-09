using LostFound.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostFound.Services.Interfaces
{
   public interface ILostItem
    {
        public List<LostIItems> GetLostItems();

        public LostIItems GetLostItem(Guid id);

        public LostIItems AddLostItem(LostIItems item);

        public LostIItems UpdateLostItem(LostIItems item);

        public LostIItems DeleteLostItem(LostIItems item);
    }
}
