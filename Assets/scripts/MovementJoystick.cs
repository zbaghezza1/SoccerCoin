using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject joystick;
    public Vector2 joystickVec;
    private Vector2 joystickTouchPos;
    private Vector2 joystickOriginalPos;
    private float joystickRadius;
    
    void Start()
    {
        joystickOriginalPos = joystick.transform.position;
        joystickRadius = joystick.GetComponent<RectTransform>().sizeDelta.y / 4;


    }

    public void PointerDownward()
    {
        joystick.transform.position = Input.mousePosition;
        joystickTouchPos = Input.mousePosition;
    }

    public void Drag(BaseEventData baseEventData)
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPos = pointerEventData.position;
        float joystickDist = Vector2.Distance(dragPos, joystickTouchPos);
    }

    public void PointerUpward()
    {
        joystickVec = Vector2.zero;
        joystick.transform.position = joystickOriginalPos;

        

    }

    // Update is called once per frame
}

    
