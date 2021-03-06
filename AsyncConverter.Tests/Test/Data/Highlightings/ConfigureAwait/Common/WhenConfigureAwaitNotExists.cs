﻿using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public async Task TestAsync()
        {
            var awaitingClass = new AwaitingClass();
            await awaitingClass;
            await awaitingClass;
        }
    }
    
    class AwaitingClass
    {
        public TaskAwaiter GetAwaiter() => throw new NotSupportedException();
    }
}
