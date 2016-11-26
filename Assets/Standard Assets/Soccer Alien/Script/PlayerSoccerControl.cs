using UnityEngine;
using System.Collections;

public class PlayerSoccerControl : MonoBehaviour {

	public float velocidade;
	public GameObject player;
	public GameObject alien;
		public bool isJumping = true;
	public float distancia;



	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "chao") {
			isJumping = false;		
		
		}

	
	}

	void Start () {
	}


	void Update () {
	


		if(Input.GetAxisRaw("Horizontal") > 0){


				player.transform.Translate (5*Time.deltaTime, 0, 0);
				alien.transform.eulerAngles = new Vector2 (0,0);


		}
		if(Input.GetAxisRaw("Horizontal") < 0)			{
			player.transform.Translate (-5*Time.deltaTime, 0, 0);
			alien.transform.eulerAngles = new Vector2(0,180);

		}

		if (Input.GetAxisRaw("Vertical") > 0){
				if(!isJumping){
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * distancia);
				isJumping = true;
			
			}


			}


	}
}
