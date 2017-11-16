
using UnityEngine;
using System.Collections;
//This script is very simple. It just tells the GameObject it is attached to to follow
//another object every frame.
public class CameraFollowObject : MonoBehaviour {

	public Transform followObject; //this will be assigned by the game manager script, which knows about the player car


	void FixedUpdate () {
		//we aren't allowed to just change a single component of a vector, so we need to 
		//store this object's current position in a temporary variable
		Vector3 currentPosition = transform.position;

		currentPosition.x = Mathf.Lerp (currentPosition.x, followObject.position.x, .5f);
	

		transform.position = currentPosition;
	}
}
