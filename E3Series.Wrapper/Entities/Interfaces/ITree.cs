﻿using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Tree COM object
    /// </summary>
    public interface ITree : IComObjectProvider<E3TreeProxy>,
        IE3Identificated, IE3Named
    {
    }
}