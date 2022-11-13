﻿using AutoMapper;
using Filmes_Api.Data.Dtos;
using Filmes_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmes_Api.Profiles
{
    public class FilmesProfile : Profile
    {
        public FilmesProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
