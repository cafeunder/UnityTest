using UnityEngine;
using System.Collections;

public class ResultRoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(MultiInput.Touched()){
			Application.LoadLevel("Title");
		}
	}
}
