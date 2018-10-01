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
        if (messageType == EventRelay.EventMessageType.SwapControls)
        {
            wasd = !wasd;

            if (wasd)
            {
                InputHandler.buttonW = InputHandler.IncreaseY;
                InputHandler.buttonS = InputHandler.DecreaseY;
                InputHandler.buttonA = InputHandler.DecreaseX;
                InputHandler.buttonD = InputHandler.IncreaseX;
                InputHandler.buttonUP = InputHandler.Unassign_Axis;
                InputHandler.buttonDOWN = InputHandler.Unassign_Axis;
                InputHandler.buttonLEFT = InputHandler.Unassign_Axis;
                InputHandler.buttonRIGHT = InputHandler.Unassign_Axis;
            }
            else
            {
                InputHandler.buttonW = InputHandler.Unassign_Axis;
                InputHandler.buttonS = InputHandler.Unassign_Axis;
                InputHandler.buttonA = InputHandler.Unassign_Axis;
                InputHandler.buttonD = InputHandler.Unassign_Axis;
                InputHandler.buttonUP = InputHandler.IncreaseY;
                InputHandler.buttonDOWN = InputHandler.DecreaseY;
                InputHandler.buttonLEFT = InputHandler.DecreaseX;
                InputHandler.buttonRIGHT = InputHandler.IncreaseX;
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
