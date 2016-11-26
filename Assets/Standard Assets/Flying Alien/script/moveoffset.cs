using UnityEngine;
using System.Collections;

public class moveoffset : MonoBehaviour {

	private Material currentMaterial;

	public float speed;

	private float offset;

	// Use this for initialization
	void Start () {

		currentMaterial = GetComponent<Renderer>().material;

	
	}
	
	// Update is called once per frame
	void Update () {
	
		offset += 0.0000f;

		currentMaterial.SetTextureOffset ("MainTex", new Vector2(offset*speed, 0));
		                      

	
	}

}
