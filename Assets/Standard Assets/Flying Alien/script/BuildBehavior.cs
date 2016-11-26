using UnityEngine;
using System.Collections;

public class BuildBehavior : MonoBehaviour {

	public float speed;
	public GameObject build;



	
	// Update is called once per frame
	void Update () {
	
		transform.position += new Vector3 (speed, 0, 0) * Time.deltaTime;



		if (transform.position.x < -50) {
			build.SetActive(false);
		
		}



	}

}
