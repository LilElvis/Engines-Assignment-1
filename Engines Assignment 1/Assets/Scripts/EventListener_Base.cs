//This script is modeled after the event system modeled in the LinkedInLearning lecture found here: https://www.lynda.com/Unity-3D-tutorials/Events-messaging-systems/160270/177261-4.html?autoplay=true

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    public List<EventRelay.EventMessageType> eventsHandled = new List<EventRelay.EventMessageType>();

    void OnEnable()
    {
        EventRelay.OnEventAction += HandleEvent;
    }

    void OnDisable()
    {
        EventRelay.OnEventAction -= HandleEvent;
    }

    string HandleEvent(EventRelay.EventMessageType messageType, MonoBehaviour sender)
    {
        if (eventsHandled.Contains(messageType))
        {
            Debug.Log("Handled Event: " + messageType + " from sender: " + sender);
            return this.ToString();
        }
        else
        {
            return this.ToString();
        }
    }
}
