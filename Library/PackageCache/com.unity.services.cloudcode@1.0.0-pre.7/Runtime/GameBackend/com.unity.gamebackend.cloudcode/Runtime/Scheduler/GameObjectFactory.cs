﻿using System;
using UnityEngine;

namespace Unity.GameBackend.CloudCode.Scheduler
{
    /// <summary>
    /// <para>A convenience class for creating GameObjects for the SdkCore.</para>
    /// 
    /// <para>As this uses the Unity API it is not thread-safe and must be called 
    /// from the main thread.</para>
    /// </summary>
    [Obsolete("This was made public unintentionally and should not be used.")]
    public static class GameObjectFactory
    {
        /// <summary> 
        /// Creates a CoreSdk game object, which will contain all components required
        /// by the SDK.
        /// </summary>
        /// <returns>The CoreSdk game object.</returns>
        public static GameObject CreateCoreSdkGameObject()
        {
            var random = new System.Random();
            string objectName = "_SdkCore-" + random.Next(0, Int32.MaxValue);

            var gameObject = new GameObject(objectName);
            
#if UNITY_WEBGL
			gameObject.AddComponent<TaskSchedulerWebGL>();
#else
			gameObject.AddComponent<TaskSchedulerThreaded>();
#endif

            UnityEngine.Object.DontDestroyOnLoad(gameObject);

            return gameObject;
        }
    }

    /// <summary>
    /// <para>A convenience class for creating GameObjects for the SdkCore.</para>
    /// 
    /// <para>As this uses the Unity API it is not thread-safe and must be called 
    /// from the main thread.</para>
    /// </summary>
    internal static class GameObjectFactoryInternal
    {
        /// <summary> 
        /// Creates a CoreSdk game object, which will contain all components required
        /// by the SDK.
        /// </summary>
        /// <returns>The CoreSdk game object.</returns>
        public static GameObject CreateCoreSdkGameObject()
        {
            var random = new System.Random();
            string objectName = "_SdkCore-" + random.Next(0, Int32.MaxValue);

            var gameObject = new GameObject(objectName);
            
#if UNITY_WEBGL
			gameObject.AddComponent<TaskSchedulerWebGLInternal>();
#else
			gameObject.AddComponent<TaskSchedulerThreadedInternal>();
#endif

            UnityEngine.Object.DontDestroyOnLoad(gameObject);

            return gameObject;
        }
    }
}