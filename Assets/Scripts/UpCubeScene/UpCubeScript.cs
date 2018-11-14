using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCubeScript : MonoBehaviour {

    [SerializeField]
    private GameObject[] Cube_pre = new GameObject[5];

	// Use this for initialization
	void Start () {
        StartCoroutine("UpCube", Cube_pre.Length);
	}

    private IEnumerator UpCube(int num){
        for (int i = 0; i < num; i++){
            Cube_pre[i].SetActive(true);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
