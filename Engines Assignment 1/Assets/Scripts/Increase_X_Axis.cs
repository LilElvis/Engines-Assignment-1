using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increase_X_Axis : Command
{
    public override void execute()
    {
        X_Axis += 0.1f;
        if (X_Axis > 1.0f) X_Axis = 1.0f;
    }

    public override void undo()
    {
        X_Axis -= 0.1f;
        if (X_Axis < 0.0f) X_Axis = 0.0f;
    }
}