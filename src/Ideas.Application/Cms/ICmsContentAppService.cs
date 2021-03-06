﻿using Abp.Application.Services.Dto;
using Ideas.Cms.Dtos;
using System.Threading.Tasks;

namespace Ideas.Cms
{
    public interface ICmsContentAppService
    {
        Task<ListResultDto<ListAllCmsContentDto>> GetAll();

        Task<GetSingleCmsContentOutput> GetCMSContent(EntityDto<int> input);

        Task<GetSingleCmsContentOutput> InsertOrUpdateCMSContent(InsertOrUpdateCmsInput input);
    }
}
