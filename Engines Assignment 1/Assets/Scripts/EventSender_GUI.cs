//This script is modeled after the event system modeled in the LinkedInLearning lecture found here: https://www.lynda.com/Unity-3D-tutorials/Events-messaging-systems/160270/177261-4.html?autoplay=true

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSender_GUI : MonoBehaviour
{
    public bool resetClicked = false;
    public bool swapClicked = false;

    void Update()
    {
        if(resetClicked)
        {
            string value = EventRelay.RelayEvent(EventRelay.EventMessageType.Reset, this);
            Debug.Log("Reset Event was seen by: " + value);
            resetClicked = false;
        }

        if (swapClicked)
        {
            string value = EventRelay.RelayEvent(EventRelay.EventMessageType.SwapControls, this);
            Debug.Log("SwapControls Event was seen by: " + value);
            swapClicked = false;
        }
    }

    public void OnResetButtonClick()
    {
        resetClicked = true;
    }

    public void OnSwapButtonClick()
    {
        swapClicked = true;
    }
}
