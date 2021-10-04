using BlogApp.Shared.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Repositories.Base
{
    public abstract class BaseRepository
    {
        protected BlogAppDbContext blogAppDbContext { get; }
        protected BaseRepository(BlogAppDbContext context)
        {
            blogAppDbContext = context;
        }

    }
}
