using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventRelay : MonoBehaviour
{
    public delegate string EventAction(EventMessageType type, MonoBehaviour sender);
    public static event EventAction OnEventAction;

    public enum EventMessageType
    {
        Finish,
        TipOver,
        Reset
    }

    public static string RelayEvent(EventMessageType messageType, MonoBehaviour sender)
    {
        return OnEventAction(messageType, sender);
    }
}
