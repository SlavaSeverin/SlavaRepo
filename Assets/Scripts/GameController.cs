using UnityEngine;
using System.Collections;

    public class GameController : SceneSingleton<GameController>
    {
        private GamePole gamepole;
      // Use this for initialization
    void Start ()
    {
        //Const konst = new Const();
        Vector3 Start = Const.StartPosition;
        float NewY = Start.y;// + 1;
        float NewX = Start.x;// - 1;
        int KolElem = Const.KolBlokov;
        GameObject IgrovoePole = new GameObject();
        
        gamepole = new GamePole();
        gamepole.IgrPole = new Pole[KolElem, KolElem];
        
        for (int y = 0; y < KolElem; y++)
        {
            for (int x = 0; x < KolElem; x++)
            {
                gamepole.IgrPole[x, y] = new Pole();
                gamepole.IgrPole[x, y].koordinata = new Koordinats(NewX, NewY);
                NewX--;
            }
            NewX = Start.x;
            NewY++;
        }

                //заполняем элементами
        foreach (var cell in gamepole.IgrPole)
        {
            
            cell.iobj = new IgrObject();
            cell.iobj.TypeIgrObj = (ObjectVisual.IgrObjType)Random.Range(0, 3);
            cell.iobj.Roditel = cell;

            //создаем vo игровые элементы.
            var GOCell = VisualObjectFactory.Instance.CreateVisualObject(cell, ObjectVisual.GetCellDescription());
            GOCell.transform.position = cell.koordinata.ToVector3();
            GOCell.transform.parent = IgrovoePole.transform;

            var GOIgrObj = VisualObjectFactory.Instance.CreateVisualObject(cell.iobj, ObjectVisual.GetFieldElementDescription(cell.iobj.TypeIgrObj));
            GOIgrObj.transform.parent = GOCell.transform;
            GOIgrObj.transform.position = new Vector3(GOIgrObj.transform.parent.position.x, GOIgrObj.transform.parent.position.y-10f, GOIgrObj.transform.parent.position.z-3f);
            
            StartCoroutine(Move(GOIgrObj));
        }
      
    }



    IEnumerator Move(GameObject IgrObj)
    {
        while (IgrObj.transform.position.y < IgrObj.transform.parent.position.y)
        {
            IgrObj.transform.position = new Vector3(IgrObj.transform.position.x, IgrObj.transform.position.y + 0.03f, IgrObj.transform.position.z);
            new WaitForSeconds(1);
            yield return null;
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
