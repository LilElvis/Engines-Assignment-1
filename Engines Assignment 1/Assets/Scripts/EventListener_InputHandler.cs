using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener_InputHandler : MonoBehaviour
{
    public List<EventRelay.EventMessageType> eventsHandled = new List<EventRelay.EventMessageType>();

    bool wasd = true;

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
        if(messageType == EventRelay.EventMessageType.SwapControls)
        {
            wasd = !wasd;

            if(wasd)
            {
                InputHandler.buttonW = new Increase_Y_Axis();
                InputHandler.buttonS = new Decrease_Y_Axis();
                InputHandler.buttonA = new Decrease_X_Axis();
                InputHandler.buttonD = new Increase_X_Axis();
                InputHandler.buttonUP = null;
                InputHandler.buttonDOWN = null;
                InputHandler.buttonLEFT = null;
                InputHandler.buttonRIGHT = null;
            }
            else
            {
                InputHandler.buttonW = null;
                InputHandler.buttonS = null;
                InputHandler.buttonA = null;
                InputHandler.buttonD = null;
                InputHandler.buttonUP = new Increase_Y_Axis();
                InputHandler.buttonDOWN = new Decrease_Y_Axis();
                InputHandler.buttonLEFT = new Decrease_X_Axis();
                InputHandler.buttonRIGHT = new Increase_X_Axis();
            }
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
