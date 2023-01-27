using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automapper2.Shared
{
    public class MapperProfile: Profile
    {
        public MapperProfile() {
            CreateMap<WeatherForecast, WeatherForecast>();
        }
    }
}
