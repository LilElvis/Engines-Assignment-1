//This script is modeled after the event system modeled in the LinkedInLearning lecture found here: https://www.lynda.com/Unity-3D-tutorials/Events-messaging-systems/160270/177261-4.html?autoplay=true

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSender : MonoBehaviour
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
