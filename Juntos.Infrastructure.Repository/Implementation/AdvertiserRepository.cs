﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.Infrastructure.Repository.Interfaces;
using Juntos.DAL.Interfaces;

namespace Juntos.Infrastructure.Repository.Implementation
{
    public class AdvertiserRepository : BaseRepository<Advertiser>, IAdvertiserRepository
    {
        public AdvertiserRepository(IAdvertiserDao AdvertiserDao)
            : base(AdvertiserDao)
        {

        }
    }
}
