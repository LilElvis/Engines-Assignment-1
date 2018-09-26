using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSender_GUI : MonoBehaviour
{
    public bool resetClicked = false;

    void Update()
    {
        if(resetClicked)
        {
            string value = EventRelay.RelayEvent(EventRelay.EventMessageType.Reset, this);
            Debug.Log("Reset Event was seen by: " + value);
            resetClicked = false;
        }
    }

    public void OnButtonClick()
    {
        resetClicked = true;
    }
}
