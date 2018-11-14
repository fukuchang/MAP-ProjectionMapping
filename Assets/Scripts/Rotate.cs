using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float time = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
        gameObject.transform.Rotate(new Vector3(Time.deltaTime * 0f, Time.deltaTime*time*180.0f, Time.deltaTime * 0f));
	}
}
