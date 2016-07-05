using UnityEngine;
using System.Collections;

public class MainRoot : MonoBehaviour {
	void Update () {
		if(MultiInput.Touched()){
			Application.LoadLevel("Result");
		}		
	}
}
