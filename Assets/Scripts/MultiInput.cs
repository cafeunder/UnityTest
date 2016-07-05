using UnityEngine;
using System.Collections;

public static class MultiInput {
	private static Vector3 touchPosition = Vector3.zero;

	public static bool Touched(){
	#if UNITY_EDITOR || UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_STANDALONE_LINUX
		return (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0) || Input.GetMouseButtonUp(0));
	#elif UNITY_IPHONE || UNITY_ANDROID
		return Input.touchCount > 0;
	#endif
		return false;
	}

	public static TouchPhase GetPhase(){
	#if UNITY_EDITOR || UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_STANDALONE_LINUX
		if(Input.GetMouseButtonDown(0)){ 
			return TouchPhase.Began;
		}
		if(Input.GetMouseButton(0)){
			return TouchPhase.Moved;
		}
		if(Input.GetMouseButtonUp(0)){
			return TouchPhase.Ended;
		}
	#elif UNITY_IPHONE || UNITY_ANDROID
		if(Input.touchCount > 0){
			return Input.GetTouch(0).phase;
		}
	#endif

		return TouchPhase.Canceled;
	}

    public static Vector3 GetPosition()
    {
	#if UNITY_EDITOR || UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_STANDALONE_LINUX
		if(MultiInput.Touched()){ return Input.mousePosition; }
	#elif UNITY_IPHONE || UNITY_ANDROID
		if(MultiInput.Touched()){
			Touch touch = Input.GetTouch(0);
			touchPosition.x = touch.position.x;
			touchPosition.y = touch.position.y;
			return touchPosition;
		}
	#endif
        return Vector3.zero;
    }
}
