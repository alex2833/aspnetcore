// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.E2ETesting;
using Microsoft.AspNetCore.Testing;
using Templates.Test.Helpers;

[assembly: AssemblyFixture(typeof(ProjectFactoryFixture))]
[assembly: AssemblyFixture(typeof(SeleniumStandaloneServer))]
[assembly: CollectionBehavior(DisableTestParallelization = true)]

