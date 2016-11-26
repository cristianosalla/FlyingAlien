using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public GameObject player;

	public float maxHeight;
	public float minHeight;
	public float aceleration;
	public float speed;
	public float gravity;


	// Use this for initialization


	void Start () {
	

	}


	// Update is called once per frame
	void Update () {



		if (Input.touchCount == 1 || Input.anyKey) {

				
						player.transform.Translate (0,+ speed + aceleration*Time.timeScale, 0);
		
					if (player.transform.position.y > maxHeight) {
				player.transform.position = new Vector2 (-13, maxHeight);		
				
						}
					if (player.transform.position.y < minHeight) {
				Application.LoadLevel("gameover");	
				
						}
			
				}else{

			player.transform.Translate (0,- gravity - aceleration*Time.timeScale, 0);


			if (player.transform.position.y > maxHeight) {
				player.transform.position = new Vector2 (-13, maxHeight);		
				
			}
			
			if (player.transform.position.y < minHeight) {
				Application.LoadLevel("gameover");			
				
			}
			
		}

	
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{

		Application.LoadLevel ("gameover");

	}



}
