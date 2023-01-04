using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IViewInventoryByName
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name);
    }
}