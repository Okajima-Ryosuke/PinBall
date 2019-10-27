using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour {

	private GameObject PointText;
	private int point = 0;

	// Use this for initialization
	void Start () {
		this.PointText = GameObject.Find ("PointText");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "LargeStarTag") {
			point += 10;
			string points = point.ToString ();
			this.PointText.GetComponent<Text> ().text = points;
		} else if (other.gameObject.tag == "SmallStarTag") {
			point += 20;
			string points = point.ToString ();
			this.PointText.GetComponent<Text> ().text = points;
		} else if (other.gameObject.tag == "LargeCloudTag") {
			point += 10;
			string points = point.ToString ();
			this.PointText.GetComponent<Text> ().text = points;
		} else if (other.gameObject.tag == "SmallCloudTag") {
			point += 20;
			string points = point.ToString ();
			this.PointText.GetComponent<Text> ().text = points;
		}
	}
}
