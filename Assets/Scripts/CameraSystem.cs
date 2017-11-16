using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour {
	private GameObject Player1; //player 1
	private GameObject Player2; //player 2
	private GameObject[] Player; //the array for the players
	private GameObject cameraAnchor; //the camera anchor

	public float xMin;//posistion parameters: x minimum
	public float xMax;//posistion parameters: x maximum
	public float yMin;//posistion parameters: y minimum
	public float yMax;//posistion parameters: y maximum

	Camera mainCamera; //the main camera


	// Use this for initialization
	void Start () {
		mainCamera = Camera.main; //assigning the camera
		Player = GameObject.FindGameObjectsWithTag ("Player");//associates it with variables with the tag 'player'
		Player1 = Player[0]; //assigning the players
		Player2 = Player[1]; //assigning the players
		cameraAnchor = GameObject.FindGameObjectWithTag ("CameraAnchorTag"); //find the camera anchor object



	}//END START FUNCTION
	
	// Update is called once per frame
	void Update () {
		Vector3 m_pos = cameraAnchor.transform.position; //I DON'T REMEMBER, BUT IT ALL WORKS...
		m_pos.x = (.5f * ((Player1.transform.position.x) + (Player2.transform.position.x))); //finding the midpoint between the players

		m_pos = Player1.transform.position;
		m_pos.y = 4.9f;
		cameraAnchor.transform.position = m_pos; // IDK 


	} //END UPDATE FUNCTION

} //END CAMERA SYESTEM SCRIPT

