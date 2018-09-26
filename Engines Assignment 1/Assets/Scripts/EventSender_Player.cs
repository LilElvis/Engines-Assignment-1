using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSender_Player : MonoBehaviour
{
    public bool hasFinished = false;
    public bool hasLost = false;

    void Update()
    {
        if(hasFinished)
        {
            string value = EventRelay.RelayEvent(EventRelay.EventMessageType.Finish, this);
            Debug.Log("Finished Event was seen by: " + value);
            hasFinished = false;
        }
        if(hasLost)
        {
            string value = EventRelay.RelayEvent(EventRelay.EventMessageType.TipOver, this);
            Debug.Log("TipOver Event was seen by: " + value);
            hasLost = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
            hasFinished = true;

        if (other.tag == "Ground")
            hasLost = true;
    }
}
