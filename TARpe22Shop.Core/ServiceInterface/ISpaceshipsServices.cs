﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpe22ShopRohusaar.Core.Domain;
using TARpe22ShopRohusaar.Core.Dto;

namespace TARpe22ShopRohusaar.Core.ServiceInterface
{
    public interface ISpaceshipsServices
    {
        Task<Spaceship> Create(SpaceshipDto dto);
        Task<Spaceship> Update(SpaceshipDto dto);
        Task<Spaceship> Delete(Guid id);
        Task<Spaceship> GetAsync(Guid id);
    }
}
