﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioApp.Application;
using PortfolioApp.Domain.Entities;
using PortfolioApp.Persistance.Contexts;
using PortfolioApp.Persistance.Repositories;

namespace PortfolioApp.Persistance
{
    public class ArticleReadRepository: ReadRepository<Article>, IArticleReadRepository
    {
        public ArticleReadRepository(PortfolioAppDbContext context) : base(context)
        {
        }
    }
}
