﻿using PlatformService.Models;

namespace PlatformService.Data;

public interface IPlatformRepo
{
    bool SaveChanges();

    IEnumerable<Platform> GetAllPlatforms();
    Platform GetPlatform(int id);
    void CreatePlatform(Platform plat);
}