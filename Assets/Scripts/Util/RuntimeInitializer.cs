﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zuaki;

public static class RuntimeInitializer
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void Init()
    {
        // シーン遷移時に破棄されないオブジェクトを生成する
        CreateDontDestroyObject<UpdateManager>();
        CreateDontDestroyObject<SoundManager>();
        CreateDontDestroyObject<ScreenManager>();

    }

    /// <summary>
    /// シーン遷移時に破棄されないオブジェクトを生成する
    /// </summary>
    /// <typeparam name="T"></typeparam>
    static GameObject CreateDontDestroyObject<T>(GameObject prefab = null) where T : MonoBehaviour
    {
        GameObject obj = CreateDontDestroyObject(prefab);
        obj.AddComponent<T>();

        if (prefab == null)
            obj.name = typeof(T).Name;

        return obj;
    }

    static GameObject CreateDontDestroyObject(GameObject prefab = null)
    {
        // prefabが指定されている場合はprefabから生成する
        // prefabがnullの場合はGameObjectを生成する
        GameObject obj = prefab
        ? GameObject.Instantiate(prefab)
        : new GameObject();
        Object.DontDestroyOnLoad(obj);

        obj.name = obj.name.Replace("(Clone)", "");
        return obj;
    }

}
