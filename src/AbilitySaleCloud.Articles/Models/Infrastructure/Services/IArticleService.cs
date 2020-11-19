using AbilitySaleCloud.Articles.Models.Infrastructure.ViewModels;
using System.Threading.Tasks;

namespace AbilitySaleCloud.Articles.Models.Infrastructure.Services
{
    public interface IArticleService
    {
        Task<int> Create(
            string description,
            int groupId,
            string taxId,
            string uomId,
            string foreign = "",
            double maxLvl = -1.00,
            int dWrhs = -1,
            int vendor = -1,
            double specPrice = 0.00,
            int discCode = -1,
            string pic = "",
            string remarks = "",
            int manufId = -1,
            string origin = ""
            );

        Task<ItemDetailsServiceModel> Details(int id);

        Task<bool> Update(int id, string description, string userId);

        Task<bool> Delete(int id, string UserId);
    }
}
