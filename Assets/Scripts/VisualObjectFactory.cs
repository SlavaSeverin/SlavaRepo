using UnityEngine;
using System.Collections.Generic;
using System;

public class VisualObjectFactory : SceneSingleton<VisualObjectFactory>
{
    private Dictionary<object, GameObject> slovarDiscript = new Dictionary<object, GameObject>();

    public GameObject CreateVisualObject(object obj, Description description)
    {
        if (slovarDiscript.ContainsKey(obj))
            return slovarDiscript[obj];
        var vobject = GameObject.Instantiate(Resources.Load(description.Prefab)) as GameObject;
        slovarDiscript[obj] = vobject;
        return vobject;
    }

    public void RemoveVisualObject(object obj)
    {
        if (!slovarDiscript.ContainsKey(obj))
            return;
        var removeObj = slovarDiscript[obj];
        slovarDiscript.Remove(obj);
        GameObject.DestroyImmediate(removeObj);
    }
}
