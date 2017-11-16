using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour{

		//public means this variable can be seen in other places, including the inspector and other scripts
	public class PlayerStats {	//creating a new class for my Player's Health Stats
	public float Health = 50f; //seting the starting health value of the player
	public Text healthReadOut; //creating the variable for the text that shows the player's current health

	} //END PUBLIC CLASS PlayerStats

	public PlayerStats playerStats = new PlayerStats ();  //defining my player stats
//		public bool regenerate = false;

		// Use this for initialization
		void Start () {
		playerStats.healthReadOut = GameObject.Find ("PlayerHealthText").GetComponent<Text> (); //setting my readout to the text object
		} // END START

		// Update is called once per frame
		void Update () {
//			if(regenerate){	//if isMoving is false
//				health++;	//increase the player health
		playerStats.healthReadOut.text = "Player Health: " + playerStats.Health.ToString(); //telling the text to include the current health value fo the player
			if (playerStats.Health <= 0f) { //if the player's health runs out, THEN
			Destroy (gameObject); //destroy the player (which is the object this scrip it applied to)


			} // END DESTROY OBJECT
		} //END UPDATE
	} //END HEALTHSCRIPT
