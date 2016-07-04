using UnityEngine;
using System.Collections;

public class TouchTest : MonoBehaviour {
	public GUIText text;
	
	// Update is called once per frame
	void Update () {
		if(MultiInput.Touched()){
			Color color = new Color(1,1,1,1.0f);
			text.color = color;
			text.text = MultiInput.GetPhase()+"";
		} else {
			Color color = new Color(0,0,0,0.0f);
			text.color = color;
		}
	}
}
