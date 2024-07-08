// <copyright file="InMemoryPropTests.cs" company="Fubar Development Junker">
// Copyright (c) Fubar Development Junker. All rights reserved.
// </copyright>

using FubarDev.WebDavServer.Tests.Support.ServiceBuilders;

namespace FubarDev.WebDavServer.Tests.PropertyStore
{
    public class InMemoryPropTests : SimplePropTests<InMemoryFileSystemServices>
    {
        public InMemoryPropTests(InMemoryFileSystemServices fsServices)
            : base(fsServices)
        {
        }
    }
}
