﻿using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Dtos.DtoProfiles;

public class TaskCodeFormatDtoMappingProfiles : Profile
{
    public TaskCodeFormatDtoMappingProfiles()
    {
        CreateMap<TaskCodeFormat, CreateTaskCodeFormatDto>().ReverseMap();
        CreateMap<TaskCodeFormat, UpdateTaskCodeFormatDto>().ReverseMap();
    }
}