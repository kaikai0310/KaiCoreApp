﻿using KaiCoreApp.Data.Entities;
using KaiCoreApp.Infrastructure.Interfaces;

namespace KaiCoreApp.Data.IRepositories
{
    public interface IContactRepository : IRepository<Contact, string>
    {
    }
}