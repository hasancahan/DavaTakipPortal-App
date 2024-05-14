﻿using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.DataAccess.EntityFramework;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.DataAccess.Concrete
{
    public class LookupFileStageLRepository : EntityRepositoryBase<LookupFileStageL, Context>, ILookupFileStageLRepository
    {
    }
}