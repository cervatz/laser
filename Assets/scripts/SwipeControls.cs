using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class SwipeControls : MonoBehaviour
{	
	public float minSwipeDistZ;
	public float minSwipeDistX;
	private Vector2 startPos;
	public Text swipe;

	void Start () {
		swipe.text = "ready";
	}

	void Update ()
	{
		//#if UNITY_ANDROID
		if (Input.touchCount > 0) {
			Touch touch = Input.touches [0];
			switch (touch.phase) {
				
			case TouchPhase.Began:				
				startPos = touch.position;				
				break;					
				
			case TouchPhase.Ended:
				
				float swipeDistVertical = (new Vector3 (0, touch.position.y, 0) - new Vector3 (0, startPos.y, 0)).magnitude;
				
				if (swipeDistVertical > minSwipeDistZ) {
					
					float swipeValue = Mathf.Sign (touch.position.y - startPos.y);
					
					if (swipeValue > 0) {
						swipe.text = "swipe up";
						print ("swipe up");
					} else if (swipeValue < 0) {
						swipe.text = "swipe down";
						print ("swipe down");
					}
							
				}

				float swipeDistHorizontal = (new Vector3 (touch.position.x, 0, 0) - new Vector3 (startPos.x, 0, 0)).magnitude;				

				if (swipeDistHorizontal > minSwipeDistX) {
					
					float swipeValue = Mathf.Sign (touch.position.x - startPos.x);
					
					if (swipeValue > 0) {
						swipe.text = "swipe right";
						print ("swipe right");
					} else if (swipeValue < 0) {
						swipe.text = "swipe left";
						print ("swipe left");
					}
							
				}
				break;
			}
		}
	}
}