using AutoMapper;
using System;

using System.Linq;
using System.Web;

namespace MvcMapping.Mappers
{
    public class AutoMapperConfig
    {

        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {

                x.AddProfile<DomainToViewModelMappingProfile>();

                x.AddProfile<ViewModelToDomainMappingProfile>();

            });
        }
    }
}