﻿using AutoMapper;
using KaiCoreApp.Application.ViewModels.Product;
using KaiCoreApp.Application.ViewModels.System;
using KaiCoreApp.Data.Entities;

namespace KaiCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Function, FunctionViewModel>();
        }
    }
}