﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPS4Controller : MonoBehaviour
{

    private GameObject StatusText;
    private GameObject StatusText_Analog;
    private string StatusDigital;

    // Use this for initialization
    void Start()
    {
        StatusText = GameObject.Find("Status");
        StatusText_Analog = GameObject.Find("Status_Analog");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            Debug.Log("□");
            StatusDigital = "□";
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            Debug.Log("✕");
            StatusDigital = "✕";
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            Debug.Log("○");
            StatusDigital = "○";
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            Debug.Log("△");
            StatusDigital = "△";
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            Debug.Log("L1");
            StatusDigital = "L1";
        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            Debug.Log("R1");
            StatusDigital = "R1";
        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            Debug.Log("L2");
            StatusDigital = "L2";
        }
        if (Input.GetKeyDown("joystick button 7"))
        {
            Debug.Log("R2");
            StatusDigital = "R2";
        }
        if (Input.GetKeyDown("joystick button 8"))
        {
            Debug.Log("Share");
            StatusDigital = "Share";
        }
        if (Input.GetKeyDown("joystick button 9"))
        {
            Debug.Log("Option");
            StatusDigital = "Option";
        }
        if (Input.GetKeyDown("joystick button 10"))
        {
            Debug.Log("L3");
            StatusDigital = "L3";
        }
        if (Input.GetKeyDown("joystick button 11"))
        {
            Debug.Log("R3");
            StatusDigital = "R3";
        }
        if (Input.GetKeyDown("joystick button 12"))
        {
            Debug.Log("PS");
            StatusDigital = "PS";
        }
        if (Input.GetKeyDown("joystick button 13"))
        {
            Debug.Log("TouchPad");
            StatusDigital = "TouchPad";
        }

        StatusText.GetComponent<TextMesh>().text = StatusDigital;


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

        StatusText_Analog.GetComponent<TextMesh>().text = 
            "LeftAnalogStick_X:" + LeftStick_X + "\n"
            + "LeftAnalogStick_Y:" + LeftStick_Y + "\n"
            + "RightAnalogStick_X:" + RightStick_X + "\n"
            + "RightAnalogStick_Y:" + RightStick_Y + "\n"
            + "R2Trigger:" + R2Trigger + "\n"
            + "L2Trigger:" + L2Trigger + "\n"
            + "Dpad_X:" + Dpad_X + "\n"
            + "Dpad_Y:" + Dpad_Y;

    }
}
