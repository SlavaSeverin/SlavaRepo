using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


    

    // Use this for initialization
    void Start () {
        Vector3 StartPosition = new Vector3(3.5f, -3.5f, 1f);
        float NewY = StartPosition.y;// + 1;
        float NewX = StartPosition.x;// - 1;
        Pole Scena = new Pole();
        Scena.SozdIgrPole();
        IgrObject Iobj = new IgrObject();
        Iobj.SozdIgrObjects();
        //var rnd = Random.Range(0,2);
        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                var cell = CreateObjektCell(Scena.pole[x,y], x, y);
                var IgOb = CreateObjekt(Iobj.igrobgect[x, y], Random.Range(0, 3), x,y);
                cell.transform.position = new Vector3(NewX, NewY, StartPosition.z);
                IgOb.transform.parent = cell.transform;
                IgOb.transform.position= new Vector3(IgOb.transform.parent.position.x, IgOb.transform.parent.position.y-10f, IgOb.transform.parent.position.z-5f);
                StartCoroutine(Move(IgOb));
                NewX--;
            }
            NewX = StartPosition.x;
            NewY++;
        }


            }

    GameObject CreateObjektCell(Object obj1,  int xx, int yy)
    {
        obj1 = Instantiate(Resources.Load("Pole")) as GameObject;
        obj1.name = "Pole" + yy.ToString() + xx.ToString();
        return obj1 as GameObject;

    }
    GameObject CreateObjekt(Object obj2, int type, int xx, int yy)
    {
        string prefname = "";
        if (type == 0) prefname = "ChekMark";
        if (type == 1) prefname = "Knob";
        if (type == 2) prefname = "InputField";
                
        obj2 = Instantiate(Resources.Load(prefname))  as GameObject;
        obj2.name = prefname + yy.ToString() + xx.ToString();
        return obj2 as GameObject;
        
    }

    IEnumerator  Move(GameObject IgrObj)
    {
        while (IgrObj.transform.position.y < IgrObj.transform.parent.position.y)
        {
            IgrObj.transform.position = new Vector3(IgrObj.transform.position.x, IgrObj.transform.position.y + 0.03f, IgrObj.transform.position.z);

            yield return null;
        }
    }
     
    // Update is called once per frame
    void Update () {
	
	}
}
