using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    private float time;
    private Vector3 cube_pos;
    [SerializeField]
    private float ratio = 0.5f;

	// Use this for initialization
	void Start () {
        cube_pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        transform.position = cube_pos + new Vector3(Mathf.Sin(2*time) * ratio, 0f, 0f);
	}
}
