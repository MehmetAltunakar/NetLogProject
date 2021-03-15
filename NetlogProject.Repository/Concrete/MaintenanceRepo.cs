﻿using EFCoreNetlogProject.Entity.Model;
using Microsoft.EntityFrameworkCore;
using NetlogProject.Core.BaseRepository;
using NetlogProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Repository.Concrete
{
    public class MaintenanceRepo : efRepositoryBase<Maintenance>, IMaintenanceRepo
    {
        public MaintenanceRepo(DbContext context) : base(context)
        {

        }   }
}
