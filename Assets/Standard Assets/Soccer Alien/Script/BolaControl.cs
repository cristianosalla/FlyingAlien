using UnityEngine;
using System.Collections;

public class BolaControl : MonoBehaviour {

	public float forca;
	public GameObject player;
	public GameObject bola;
	public float forca_cima;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		


	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "player" && Input.GetAxisRaw("Vertical") >= 0) {
			
			if(player.transform.position.x < bola.transform.position.x)
			{
				GetComponent<Rigidbody2D>().AddForce(Vector2.right * forca);
				GetComponent<Rigidbody2D>().AddForce(-Vector2.up * 100);
			}
			
			if(player.transform.position.x > bola.transform.position.x)
			{
				GetComponent<Rigidbody2D>().AddForce(-Vector2.right * forca);
				GetComponent<Rigidbody2D>().AddForce(-Vector2.up * 100);
			}
			if(player.transform.position.y < bola.transform.position.y)
			{
				GetComponent<Rigidbody2D>().AddForce(Vector2.up * forca_cima);
				
			}
			if(player.transform.position.y >= bola.transform.position.y)
			{
				GetComponent<Rigidbody2D>().AddForce(-Vector2.up * forca_cima);
				
			}
			
		}

		
		
	}

}
