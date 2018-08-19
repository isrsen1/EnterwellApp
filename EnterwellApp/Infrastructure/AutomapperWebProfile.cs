using EnterwellApp.Domain;
using EnterwellApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterwellApp.Infrastructure
{
    public class AutomapperWebProfile: AutoMapper.Profile
    {
        public static void Run()
        {
            AutoMapper.Mapper.Initialize(a => 
                {
                    a.AddProfile<AutomapperWebProfile>();
                }
            );
        }
        public AutomapperWebProfile()
        {
            CreateMap<ProizvodDomainModel, ProizvodViewModel>();
            CreateMap<ProizvodViewModel, ProizvodDomainModel>();
        }
    }
}