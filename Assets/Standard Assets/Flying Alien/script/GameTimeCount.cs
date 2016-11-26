using UnityEngine;
using System.Collections;
using System;


public class GameTimeCount : MonoBehaviour {

	private float hora;
	public int Score;

	public TextMesh pontos;
	// Use this for initialization
	void Start () {
	



	}
	
	// Update is called once per frame
	void Update () {
	
		hora = Time.timeSinceLevelLoad * 43;
		Score = (int)Math.Round(hora);

		pontos.text = Score.ToString ();



		if (Score > PlayerPrefs.GetInt ("recorde")) {
			PlayerPrefs.SetInt("recorde", Score);
				}
	

		PlayerPrefs.SetInt ("atual", Score);



	
	}

		

}
