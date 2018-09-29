using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSender_InputHandler : MonoBehaviour
{
    public bool trigger = false;

    void Update()
    {
        if(trigger)
        {
            //string value = EventRelay.RelayEvent(EventRelay.EventMessageType., this);
            //Debug.Log("unnamed Event was seen by: " + value);
        }
    }
}
