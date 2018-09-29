using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    static public Command buttonW = new Increase_Y_Axis();
    static public Command buttonS = new Decrease_Y_Axis();
    static public Command buttonA = new Decrease_X_Axis();
    static public Command buttonD = new Increase_X_Axis();
    static public Command buttonUP;
    static public Command buttonDOWN;
    static public Command buttonLEFT;
    static public Command buttonRIGHT;

    public void handleInput()
    {
        if (Input.GetButton("W")) buttonW.execute();
        if (Input.GetButton("S")) buttonS.execute();
        if (Input.GetButton("A")) buttonA.execute();
        if (Input.GetButton("D")) buttonD.execute();
        if (Input.GetButton("UP")) buttonUP.execute();
        if (Input.GetButton("DOWN")) buttonDOWN.execute();
        if (Input.GetButton("LEFT")) buttonLEFT.execute();
        if (Input.GetButton("RIGHT")) buttonRIGHT.execute();
    }

    public void Update()
    {
        handleInput();
    }
}
