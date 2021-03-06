﻿using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3BinData COM object
    /// </summary>
    public interface IBinData : IProxyProvider<E3BinDataProxy>
    {
    }
}