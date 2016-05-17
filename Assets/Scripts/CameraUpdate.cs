using UnityEngine;
using System.Collections;

public class CameraUpdate : MonoBehaviour {

    private Vector3 newPosition;
    [SerializeField] private SharOsn osnshar;
    [SerializeField]     private Shar sharik1;
    [SerializeField]    private Shar sharik2;
    [SerializeField]    private Shar sharik3;
    [SerializeField]    private Shar sharik4;
    [SerializeField]    private Shar sharik5;
    [SerializeField]    private Shar sharik6;
    [SerializeField]    private Shar sharik7;
    [SerializeField]    private Shar sharik8;
    [SerializeField]    private Shar sharik9;
    [SerializeField]    private Shar sharik10;
    [SerializeField]    private Shar sharik11;
    [SerializeField]    private Shar sharik12;
    [SerializeField]    private Shar sharik13;
    [SerializeField]    private Shar sharik14;
    [SerializeField]    private Shar sharik15;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray Луч = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(Луч, out hit, 100))
            {
                //Destroy(hit.transform.gameObject);
                //print("Объект уничтожен");
                
                //print(newPosition);

                if (hit.transform.tag == "Kiy")
                {
                    newPosition = new Vector3(3.8f, 1f);
                    hit.transform.position = newPosition;
                    
                    osnshar.transform.position = new Vector3(-5.3f, 0f, 0f);
                    sharik1.Udar(); sharik2.Udar(); sharik3.Udar(); sharik4.Udar(); sharik5.Udar(); sharik6.Udar();
                    sharik7.Udar(); sharik8.Udar(); sharik9.Udar(); sharik10.Udar(); sharik11.Udar(); sharik12.Udar();
                    sharik13.Udar(); sharik14.Udar(); sharik15.Udar();
                }

                
            }
        }
    }
}
