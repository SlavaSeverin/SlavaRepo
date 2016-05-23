using UnityEngine;
using System.Collections;

public class Pole{

    //GameObject IgrPole = ;

    public Object[,] pole;

    public void SozdIgrPole()
    {
        
        pole = new Object[8,8];
        int x, y; x = y = 0;

        for (y = 0; y < 8; y++)
        {
            for (x = 0; x < 8; x++)
            {
                pole[x, y] = new Object();
                
            }
        }
   }

	// Update is called once per frame
	void Update () {
	
	}
}
