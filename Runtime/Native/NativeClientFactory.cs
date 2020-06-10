﻿using Backtrace.Unity.Model;

namespace Backtrace.Unity.Runtime.Native
{
    internal class NativeClientFactory
    {
        internal static INativeClient GetNativeClient(BacktraceConfiguration configuration, string gameObjectName)
        {
#if UNITY_ANDROID 
            return new Android.NativeClient(gameObjectName, configuration.HandleANR);
#else
            return null;
#endif
        }
    }
}