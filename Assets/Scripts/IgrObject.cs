using UnityEngine;
using System.Collections.Generic;


public class IgrObject
{
   
    public Object[,] igrobgect;

    
    public void SozdIgrObjects()
    {
        igrobgect = new Object[8, 8];
        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                igrobgect[x, y] = new Object();
                //igrobgect[x, y].
            }
        }
    }

   
}

