using UnityEngine;
using System.Collections;

public class GameOverControl : MonoBehaviour {

	public TextMesh record;
	public TextMesh atual;



	// Use this for initialization
	void Start () {
	


		atual.text = PlayerPrefs.GetInt ("atual").ToString();
		record.text = PlayerPrefs.GetInt ("recorde").ToString();

	}
	
	// Update is called once per frame
	void Update () {


		if(Input.touchCount == 1 || Input.anyKey){	
		
			Application.LoadLevel("game");
		
		}

      
	
	}
}
