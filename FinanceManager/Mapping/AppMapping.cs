using AutoMapper;
using FinanceManager.Domain;
using FinanceManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Mapping
{
    public class AppMapping : Profile
    {
        public AppMapping()
        {
            CreateMap<User, UserModel>().ReverseMap();
        }
    }
}
