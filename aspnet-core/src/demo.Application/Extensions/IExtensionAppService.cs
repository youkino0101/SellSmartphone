﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace demo.Extensions
{
    public interface IExtensionAppService : IApplicationService
    {
        /// <summary>   
        /// NV - Nhân viên
        /// </summary>
        /// <param name="code"></param>       
        /// <returns></returns>
        Task<string> GetGenerateNumber(string code);
    }
}
