﻿#if NETSTANDARD1_3

using System.Reflection;

namespace ServiceStack
{
    public abstract class AppHostBase : ServiceStackHost
    {
        protected AppHostBase(string serviceName, params Assembly[] assembliesWithServices) 
            : base(serviceName, assembliesWithServices) {}
    }
}

#endif
