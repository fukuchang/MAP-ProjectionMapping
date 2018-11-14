using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieTextureTest : MonoBehaviour
{
	public MovieTexture mTexture;
	public Material mat;
	void Start ()
	{
		//mat.mainTexture = mTexturel;
		mTexture.loop = true;
		mTexture.Play();
	}
	void Update () {
		
	}
}
