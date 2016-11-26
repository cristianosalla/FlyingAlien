using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public TextMesh record; 

	// Use this for initialization
	void Start () {
	
		record.text = PlayerPrefs.GetInt("recorde").ToString();

	}
	
	// Update is called once per frame
	void Update () {


		if(Input.touchCount == 1 || Input.anyKey){	
		
			Application.LoadLevel("game");
		
		}

     
	
	}
}
