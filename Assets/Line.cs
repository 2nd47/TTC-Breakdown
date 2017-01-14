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

	// Use this for initialization
	void Start () {
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
}
