﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Helpers
{
    public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        private static volatile T instance=null;
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = FindObjectOfType(typeof(T)) as T;
                }
                return instance;
            }
        }
    }
}