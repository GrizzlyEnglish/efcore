// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.EntityFrameworkCore.TestUtilities;

namespace Microsoft.EntityFrameworkCore
{
    public class KeysWithConvertersInMemoryTest : KeysWithConvertersTestBase<
        KeysWithConvertersInMemoryTest.KeysWithConvertersInMemoryFixture>
    {
        public KeysWithConvertersInMemoryTest(KeysWithConvertersInMemoryFixture fixture)
            : base(fixture)
        {
        }

        public class KeysWithConvertersInMemoryFixture : KeysWithConvertersFixtureBase
        {
            protected override ITestStoreFactory TestStoreFactory
                => InMemoryTestStoreFactory.Instance;
        }
    }
}
