using UnityEngine;
using System.Collections;

public class Shar : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    public void Udar()
    {

        gameObject.transform.position = new Vector3(Random.Range(-10.5f, 10.5f), Random.Range(-6f, 6f));
    }
}
