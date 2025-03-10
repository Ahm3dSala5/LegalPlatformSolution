﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Infrastructure.Persistence.Context;
using LegalPlatform.Infrastructure.Repository;
using LegalPlatform.Service.Abstraction.Business;
using Microsoft.Extensions.Configuration;

namespace LegalPlatform.Service.Implementation.Business
{
    public class CommentService : MainRepository<Comment>, ICommentService
    {
        public CommentService(LegalPlatformContext context, IConfiguration config) : base(context, config)
        {

        }
    }
}
