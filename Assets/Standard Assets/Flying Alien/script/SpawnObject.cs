using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnObject : MonoBehaviour {


	public float maxHeight;
	public float minHeight;

	private float current_rateSpawn;

	public float rateSpawn;

	public int maxBuild;

	public GameObject pre_fab;

	public List<GameObject> build;

	// Use this for initialization
	void Start () {
	
		for (int i = 0; i < maxBuild; i++) {
				
			GameObject tempBuild = Instantiate(pre_fab) as GameObject;
			build.Add(tempBuild);
			tempBuild.SetActive(false);
		
		}

	}
	
	// Update is called once per frame
	void Update () {
	
		current_rateSpawn += Time.deltaTime;

		if (current_rateSpawn > rateSpawn) {
				
			current_rateSpawn = 0;
			Spawn ();
		}

	}

	private void Spawn(){

		float randPosition = Random.Range (minHeight, maxHeight);
	
		GameObject tempBuild = null;

		for (int i = 0; i < maxBuild; i++) {
			
			if(build[i].activeSelf == false){
			
				tempBuild = build[i];
				break;
			}

		}

		if (tempBuild != null) {
						tempBuild.transform.position = new Vector3 (transform.position.x, randPosition, transform.position.z);
						tempBuild.SetActive (true);
				}

	}

}



