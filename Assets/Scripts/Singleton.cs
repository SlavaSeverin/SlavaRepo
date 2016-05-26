﻿using UnityEngine;
using System.Collections;

public class SceneSingleton<T> : MonoBehaviour where T : MonoBehaviour
{

    private static T _instance = null;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject((typeof(T)).ToString());
                _instance = go.AddComponent<T>();

            }
            return _instance;
        }
    }
}
