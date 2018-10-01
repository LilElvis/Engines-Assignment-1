using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class HelloWorldPluginWrapper : MonoBehaviour
{
    const string DLL_NAME = "HelloWorldPlugin";

    // Use this for initialization
 
    [DllImport(DLL_NAME)]
    private static extern int Add(int first, int second);
    [DllImport(DLL_NAME)]
    private static extern System.IntPtr SayHello();
    [DllImport(DLL_NAME)]
    private static extern void SetGreeting(string greeting);

    // Update is called once per frame
    void Update ()
    {
		if(Input.GetKeyDown(KeyCode.H))
        {
            print(Add(2000,19));

            SetGreeting("Welcome to Gremlin Sim 2K19!");

            string message = Marshal.PtrToStringAnsi(SayHello());
            print(message);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            SetGreeting("Thanks for playing!");

            string message = Marshal.PtrToStringAnsi(SayHello());
            print(message);
        }
    }
}
