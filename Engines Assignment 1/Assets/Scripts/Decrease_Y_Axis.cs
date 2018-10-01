using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decrease_Y_Axis : Command
{
    public override void execute()
    {
        Y_Axis -= 0.1f;
        if (Y_Axis < -1.0f) Y_Axis = -1.0f;
    }

    public override void undo()
    {
        Y_Axis += 0.1f;
        if (Y_Axis > 0.0f) Y_Axis = 0.0f;
    }
}