using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public abstract void execute();

    public static float X_Axis = 0.0f;
    public static float Y_Axis = 0.0f;
}