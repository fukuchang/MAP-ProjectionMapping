using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEditor;
using UnityEngine;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Schema;
using UnityEngine.Experimental.UIElements;

public class State : MonoBehaviour
{

	public List < Material > materials = new List < Material >();
	private Renderer _renderer;
	private int _num;

	private void OnEnable()
	{
		init();
	}

	void Start()
	{
		SetChildrenMaterials(materials[0]);
	}

	void Update()
	{
		if (Input.GetButtonDown("Left"))
		{
			Debug.Log("Left Key Pressed");
		}
	}

	void init()
	{
		_renderer = this.GetComponent < Renderer >();
		_renderer.material = materials[0];
		_num = materials.Count;
	}

	
	//set children's materials 
	void SetChildrenMaterials(Material mat)
	{
		var children = gameObject.GetComponentsInChildren < Transform >().ToList()
					   .Where(x => x.childCount == 0);

		foreach (var c in children)
		{
			c.GetComponent < Renderer >().material = mat;
		}
	}
}