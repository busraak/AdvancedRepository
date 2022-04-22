﻿using AdvancedRepository.Core;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Repository.Classes
{
    public class CityRepos:BaseRepository<Cities>,ICityRepos
    {
        public CityRepos(SirketContext db):base(db)
        {

        }
    }
}
