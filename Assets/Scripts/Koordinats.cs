using UnityEngine;

public class Koordinats
    {
    public float xx;
    public float yy;

    public Koordinats(float x, float y)
    {
        xx = x;
        yy = y;
    }

    public Vector3 ToVector3()
    {
        return new Vector3(xx, yy,-1f);
    }
}

