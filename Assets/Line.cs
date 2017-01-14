using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Line : MonoBehaviour {

	public Player player;
	public Station station1;
	public Station station2;
	public bool running;
	public int[] closureTimes;

	private Color baseColor;
	private bool highlight_up;
	private float highlight_timeFrame = 4;

	// Use this for initialization
	void Start () {
		baseColor = GetComponent<Renderer> ().material.color;
		running = true;
	}

	// Update is called once per frame
	void Update () {
		if(closureTimes.Contains(player.currentTime))
			running = false;
		else
			running = true;
	}

	void OnMouseDown() {
		if(running == true) {
			if(player.currentStation == station1)
				player.currentStation = station2;
			else if(player.currentStation == station2)
				player.currentStation = station1;
			player.currentTime += 1;
		}
	}

	void OnMouseOver() {
		if (!running) {
			return;
		}
		Color result = GetComponent<Renderer> ().material.color;
		if (result.b > 0.7) {
			if (result.b > 0.8) {
				result.b = 0.7f;
			}
			highlight_up = false;
		}
		if (result.b < 0.4) {
			highlight_up = true;
		}
		if (highlight_up) {
			result.b += Time.deltaTime / highlight_timeFrame;
		} else {
			result.b -= Time.deltaTime / highlight_timeFrame;
		}
		GetComponent<Renderer> ().material.color = result;
	}

	void OnMouseExit() {
		GetComponent<Renderer> ().material.color = baseColor;
	}
}
