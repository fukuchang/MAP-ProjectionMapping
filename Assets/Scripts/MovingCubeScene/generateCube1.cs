using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateCube1 : MonoBehaviour
{
    private GameObject prefab;
    private int cube_num = 15;
    private Vector3 generate_cube_pos = new Vector3(1.1f, -2f, -1f);
    private Vector3 _startPosition;

    void Start()
    {
        StartCoroutine("Sample", cube_num);
    }

    private IEnumerator Sample(int num)
    {
        for (int j = 0; j < num / 3; j++){
            for (int i = 0; i < 3; i++)
            {
                prefab = (GameObject)Resources.Load("Cube1");
                Instantiate(prefab, prefab.transform.position + new Vector3(-i * 1.0f, j * 1.0f, 0f), Quaternion.identity);

                yield return new WaitForSeconds(0.3f);
            }      
        }

    }
}
