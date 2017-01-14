using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour {

    float time;
    public Text closurelisttext;
    List<Line> lines = new List<Line>();

	void Start () {
        time = 0.0f;
	}
    void makeLines() {
        lines.Add(new Line());
        lines.Add(new Line());
        lines.Add(new Line());
        lines.Add(new Line());
        lines.Add(new Line());
    }

    void updateController(Line line){
        time += line.time; //time_between?
        if (time == 2.0) {
            //add closure from station 2 to station 3
            //change text of closure list

            closurelisttext.text += "There is a closure between Station 2 and 3\n";
        }        

    } 

}
