using UnityEngine;
using System.Collections;

public class TouchState : MonoBehaviour {
	public GUIText stateText;

	void Update () {
		if(MultiInput.Touched()){
			Color color = new Color(1,1,1,1.0f);
			stateText.color = color;
			stateText.text = MultiInput.GetPhase()+"";
		} else {
			Color color = new Color(0,0,0,0.0f);
			stateText.color = color;
		}
	}
}
