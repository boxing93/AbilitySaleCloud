using AbilitySaleCloud.Articles.Models.DatabaseContext;
using AbilitySaleCloud.Articles.Models.Infrastructure.ViewModels;
using System.Threading.Tasks;

namespace AbilitySaleCloud.Articles.Models.Infrastructure.Services
{
    public class ArticleService : IArticleService
    {
        private readonly ArticleContext data;

        public ArticleService(ArticleContext data)
            => this.data = data;

        public async Task<int> Create(
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
                                    string origin = "")
        {
            var article = new Article
            {
                Description = description,
                ForeignName = foreign,
                ArticleGroupID = groupId,
                TaxGroupID = taxId,
                MaxInvLvl = maxLvl,
                DfltWrhs = dWrhs,
                PrefVendor = vendor,
                UoMGroupID = uomId,
                SpclDscnt = specPrice,
                DscntCode = discCode,
                OpenBlnc = 0.00,
                Picture = pic,
                ManufID = manufId,
                AvgPrice = 0.00,
                CountryOrigin = origin
            };

            this.data.Add(article);

            await this.data.SaveChangesAsync();

            return article.ArticleID;
        }

        public Task<bool> Delete(int id, string UserId)
        {
            throw new System.NotImplementedException();
        }

        public Task<ItemDetailsServiceModel> Details(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(int id, string description, string userId)
        {
            throw new System.NotImplementedException();
        }
    }
}
