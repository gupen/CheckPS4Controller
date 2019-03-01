using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPS4Controller : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            Debug.Log("□");
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            Debug.Log("✕");
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            Debug.Log("○");
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            Debug.Log("△");
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            Debug.Log("L1");
        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            Debug.Log("R1");
        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            Debug.Log("L2");
        }
        if (Input.GetKeyDown("joystick button 7"))
        {
            Debug.Log("R2");
        }
        if (Input.GetKeyDown("joystick button 8"))
        {
            Debug.Log("Share");
        }
        if (Input.GetKeyDown("joystick button 9"))
        {
            Debug.Log("Option");
        }
        if (Input.GetKeyDown("joystick button 10"))
        {
            Debug.Log("L3");
        }
        if (Input.GetKeyDown("joystick button 11"))
        {
            Debug.Log("R3");
        }
        if (Input.GetKeyDown("joystick button 12"))
        {
            Debug.Log("PS");
        }
        if (Input.GetKeyDown("joystick button 13"))
        {
            Debug.Log("TouchPad");
        }


        //Left Stick
        //1:→↓
        //-1:←↑
        float LeftStick_X = Input.GetAxis("LeftAnalogStick_X");
        Debug.Log("LeftAnalogStick_X:" + LeftStick_X );
        float LeftStick_Y = Input.GetAxis("LeftAnalogStick_Y");
        Debug.Log("LeftAnalogStick_Y:" + LeftStick_Y);

        //Right Stick
        //1:→↓
        //-1:←↑
        float RightStick_X = Input.GetAxis("RightAnalogStick_X");
        Debug.Log("RightAnalogStick_X:" + RightStick_X );
        float RightStick_Y = Input.GetAxis("RightAnalogStick_Y");
        Debug.Log("RightAnalogStick_Y:" + RightStick_Y);

        //L2|R2Trigger
        //1:Push
        //-1:Release
        float R2Trigger = Input.GetAxis("R2Trigger");
        Debug.Log("R2Trigger:" + R2Trigger);
        float L2Trigger = Input.GetAxis("L2Trigger");
        Debug.Log("L2Trigger:" + L2Trigger);


        //Dpad
        //1:↑→
        //-1:↓←
        float Dpad_X = Input.GetAxis("Dpad_X");
        Debug.Log("Dpad_X:" + Dpad_X);
        float Dpad_Y = Input.GetAxis("Dpad_Y");
        Debug.Log("Dpad_Y:" + Dpad_Y);

    }
}
