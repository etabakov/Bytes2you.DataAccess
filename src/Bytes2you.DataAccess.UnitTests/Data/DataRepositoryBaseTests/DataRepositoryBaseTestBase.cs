﻿using System;
using System.Linq;
using Bytes2you.DataAccess.UnitTests.Testing.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.DataAccess.UnitTests.Data.DataRepositoryBaseTests
{
    public abstract class DataRepositoryBaseTestBase
    {
        protected UnitOfWorkMock<PersonDataEntityMock, int> UnitOfWorkMock { get; private set; }
        protected DataRepositoryBaseMock<PersonDataEntityMock> DataRepository { get; private set; }

        [TestInitialize]
        public void Initialize()
        {
            // Arrange.
            this.UnitOfWorkMock = new UnitOfWorkMock<PersonDataEntityMock, int>();
            this.DataRepository = new DataRepositoryBaseMock<PersonDataEntityMock>(this.UnitOfWorkMock);
        }

        [TestCleanup]
        public void Cleanup()
        {
            this.UnitOfWorkMock = null;
            this.DataRepository = null;
        }
    }
}