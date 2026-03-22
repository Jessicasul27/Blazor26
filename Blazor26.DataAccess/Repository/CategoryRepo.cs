

using Blazor26.DataAccess.DataAccess;
using Blazor26.Models.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor26.DataAccess.Repository
{
    public class CategoryRepo : Repository<Category>, ICategoryRepo
    {

        private readonly AppDBContext _dbContext;

        public CategoryRepo(AppDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
        }
        

        

       

      
    }
}
