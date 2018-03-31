﻿using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="ISupply" />
    /// <summary>
    /// Implementation of ISupply interface
    /// </summary>
    public class E3Supply : ComWrapperBase<E3SupplyProxy>, ISupply
    {
        public E3Supply(E3Job job)
            : base(job, () => new E3SupplyProxy(job.ComObject.CreateSupplyObject()))
        {
        }
    }
}