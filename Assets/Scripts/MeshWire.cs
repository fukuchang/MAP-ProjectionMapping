using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshWire : MonoBehaviour {

	void Start () {
		MeshFilter meshFilter = GetComponent<MeshFilter>();
		meshFilter.mesh.SetIndices(meshFilter.mesh.GetIndices(0), MeshTopology.LineStrip, 0);
	}
	
	void Update () {
		
	}
}
