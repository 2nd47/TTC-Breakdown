using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Station : MonoBehaviour {

	// Store the prefab in the script from the editor
	public GameObject buttonPrefab;
	// Store all connections from the editor (as GameObjects)
	public Station[] connections;
	// Display name for the station
	public string displayName;

	private Vector3 pos;
	// Store its screen position
	private Vector3 screenPos;

	// Use this for initialization
	void Start () {
		pos = transform.position;
		screenPos = Camera.main.WorldToScreenPoint (pos);
		displayMoves();
	}

	// Display options for route selection when arriving
	void displayMoves () {
		GameObject button;
		Text buttonText;

		// Set initial screen position for buttons
		Vector3 buttonAnchor = new Vector3(screenPos.x, screenPos.y, screenPos.z);

		// Find lines connected to this station that are open
		int i;
		for (i = 0; i < connections.Length; i++) {
			// needs to be changed so that it checks if the line is open
			//if (connections[i] != null) {
				// Display HUD elements to move to station
				button = Instantiate(buttonPrefab, buttonAnchor, Quaternion.identity);
				// Update position so that they don't stack weirdly
				buttonText = button.GetComponent<Text>();
				buttonText.text = displayName;
				//Player.moveTo(connections);
			//}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
