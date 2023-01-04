using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class ViewInventoryByName : IViewInventoryByName
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoryByName(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }
        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name)
        {
            return await this.inventoryRepository.GetInventoriesByName(name);
        }
    }
}