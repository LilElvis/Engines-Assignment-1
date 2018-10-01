//This script is modeled after the event system modeled in the LinkedInLearning lecture found here: https://www.lynda.com/Unity-3D-tutorials/Events-messaging-systems/160270/177261-4.html?autoplay=true

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener_GUI : MonoBehaviour
{
    public List<EventRelay.EventMessageType> eventsHandled = new List<EventRelay.EventMessageType>();

    public bool hasFinished = false;
    public bool hasLost = false;

    GUIStyle styleVictory = new GUIStyle();
    GUIStyle styleDefeat = new GUIStyle();

    void OnEnable()
    {
        EventRelay.OnEventAction += HandleEvent;
    }

    void OnDisable()
    {
        EventRelay.OnEventAction -= HandleEvent;
    }

    void Start()
    {
        styleVictory.alignment = TextAnchor.MiddleCenter;
        styleVictory.fontSize = 68;
        styleVictory.normal.textColor = new Color(0.5f, 1.0f, 0.5f, 1.0f);

        styleDefeat.alignment = TextAnchor.MiddleCenter;
        styleDefeat.fontSize = 68;
        styleDefeat.normal.textColor = new Color(1.0f, 0.5f, 0.5f, 1.0f);
    }

    void OnGUI()
    {
        if(hasFinished)
        GUI.Label(new Rect(200, 200, 300, 50), "VICTORY", styleVictory);

        if(hasLost)
        GUI.Label(new Rect(200, 200, 300, 50), "DEFEAT", styleDefeat);
    }

    string HandleEvent(EventRelay.EventMessageType messageType, MonoBehaviour sender)
    {
        if(messageType == EventRelay.EventMessageType.Finish)
        {
            hasFinished = true;
        }

        if(messageType == EventRelay.EventMessageType.TipOver)
        {
            hasLost = true;
        }

        if (messageType == EventRelay.EventMessageType.Reset)
        {
            hasFinished = false;
            hasLost = false;
        }

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
