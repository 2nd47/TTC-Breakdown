using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour {

	// Store the prefab in the script from the editor
	public Transform buttonPrefab;
	// Store all connections from the editor
	public Line[] connections;
	// Display name for the station
	public string displayName;

	private Vector3 pos;
	// Store its screen position
	private Vector3 screenPos;

	// Use this for initialization
	void Start () {
		pos = transform.position;
		screenPos = Camera.main.WorldToScreenPoint (pos);
	}

	// Display options for route selection when arriving
	void displayMoves () {
		Transform button;
		Text buttonText;

		// Set initial screen position for buttons
		Transform buttonAnchor = Vector3(screenPos.x + 20, screenPos.y + 20, screenPos.z);

		// Find lines connected to this station that are open
		for (int i; i < connections.Length; i++) {
			if (connections[i].isOpen()) {
				// Display HUD elements to move to station
				button = Instantiate(buttonPrefab, buttonAnchor, Quaternion.identity);
				// Update position so that they don't stack weirdly
				buttonText = button.getComponent<Text> ();
				buttonText.text = displayName;
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
