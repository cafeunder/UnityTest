using UnityEngine;
using System.Collections;

public class TouchPosition : MonoBehaviour {
	public GUIText positionText;

	void Update () {
		if(MultiInput.Touched()){
			Color color = new Color(1,1,1,1.0f);
			positionText.color = color;
			Vector3 pos = MultiInput.GetPosition();
			positionText.text = pos.x + "," + pos.y + "," + pos.z;
		} else {
			Color color = new Color(0,0,0,0.0f);
			positionText.color = color;
		}	
	}
}
