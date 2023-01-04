using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public class ViewInventoryByName : IInventoryRepository
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoryByName(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }
        public async IEnumerable<Inventory> ExecuteAsync(string name)
        {

        }
    }
}