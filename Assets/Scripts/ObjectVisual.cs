using UnityEngine;

public class ObjectVisual
{
    public string PrefabName;
    public enum IgrObjType
    {
        ChekMark,
        Knob,
        Input
    }
    private static readonly Description poleDescription = new Description
    {
        Prefab = "Pole"
    };

    private static readonly Description[] IgrObjDescription = new[]{
                        new Description {Prefab = "ChekMark"},
                        new Description {Prefab = "Knob"},
                        new Description {Prefab = "InputField"}};

    public static Description GetFieldElementDescription(IgrObjType typeElment)
    {
        //опасно, можно схватить оут оф рэндж
        return IgrObjDescription[(int)typeElment];
    }

    public static Description GetCellDescription()
    {
        //опасно, можно схватить оут оф рэндж
        return poleDescription;
    }
}
