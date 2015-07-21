﻿using System;
using System.Linq;

namespace Bytes2you.DataAccess.EntityFramework.UnitTests.Testing.Mocks
{
    public class EfRepositoryMock<TDataEntity, TId> : EfRepository<TDataEntity, TId>
        where TDataEntity : class, IDataEntity<TId>, new()
    {
        public EfRepositoryMock(IEfUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}