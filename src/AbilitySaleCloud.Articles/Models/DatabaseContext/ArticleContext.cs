using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbilitySaleCloud.Articles.Models.DatabaseContext
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options) : base(options)
        {
<<<<<<< HEAD
        }
=======
            
        }
        DBSet<ArticleContext.Articles> articles = new DBSet<ArticleContext.Articles>();
>>>>>>> 082bc304e0c3a998477aaa2a2f85ccd0d511c031
    }
}
