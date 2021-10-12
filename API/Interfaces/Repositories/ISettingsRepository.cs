﻿using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs.Settings;
using API.Entities;
using API.Entities.Enums;

namespace API.Interfaces.Repositories
{
    public interface ISettingsRepository
    {
        void Update(ServerSetting settings);
        Task<ServerSettingDto> GetSettingsDtoAsync();
        ServerSettingDto GetSettingsDto();
        Task<ServerSetting> GetSettingAsync(ServerSettingKey key);
        Task<IEnumerable<ServerSetting>> GetSettingsAsync();

    }
}
