using UnityEngine;
using System.Collections;

public class TouchSprite : MonoBehaviour {

	public static bool guiTouch = false;

	public void TouchInput (){
		if (Input.touchCount > 0) {
				switch (Input.GetTouch (0).phase) {
				case TouchPhase.Began:
					SendMessage ("OnFirstTouchBegan", SendMessageOptions.DontRequireReceiver);
					SendMessage ("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
					guiTouch = true;
					break;
				/*case TouchPhase.Stationary:
					SendMessage ("OnFirstTouchStayed", SendMessageOptions.DontRequireReceiver);
					SendMessage ("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
					guiTouch = true;
					break;*/
				case TouchPhase.Moved:
					SendMessage ("OnFirstTouchMoved", SendMessageOptions.DontRequireReceiver);
					SendMessage ("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
					guiTouch = true;
					break;
				case TouchPhase.Ended:
					SendMessage ("OnFirstTouchEnded", SendMessageOptions.DontRequireReceiver);
					guiTouch = false;
					break;

			}
		}
	}


}
