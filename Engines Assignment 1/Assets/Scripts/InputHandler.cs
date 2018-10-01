using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    static public Increase_X_Axis IncreaseX = new Increase_X_Axis();
    static public Increase_Y_Axis IncreaseY = new Increase_Y_Axis();
    static public Decrease_X_Axis DecreaseX = new Decrease_X_Axis();
    static public Decrease_Y_Axis DecreaseY = new Decrease_Y_Axis();
    static public Command buttonW = IncreaseY;
    static public Command buttonS = DecreaseY;
    static public Command buttonA = DecreaseX;
    static public Command buttonD = IncreaseX;
    static public Command buttonUP = null;
    static public Command buttonDOWN = null;
    static public Command buttonLEFT = null;
    static public Command buttonRIGHT = null;

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

        if(!Input.anyKey)
        {
            buttonW.undo();
            buttonS.undo();
            buttonA.undo();
            buttonD.undo();
            buttonUP.undo();
            buttonDOWN.undo();
            buttonLEFT.undo();
            buttonRIGHT.undo();   
        }
    }

    public void Update()
    {
        handleInput();
    }
}
