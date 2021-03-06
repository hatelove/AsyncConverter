﻿using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public async Task TestAsync()
        {
            {caret}Method().ToString();
        }

        public Class Method()
        {
            return 5;
        }

        public Task<Class> MethodAsync()
        {
            return Task.FromResult<Class>(null);
        }
    }
}
