using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPS4Controller_Android : MonoBehaviour {


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
            StatusDigital = "□";
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            StatusDigital = "✕";
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            StatusDigital = "△";
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            StatusDigital = "L1";
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            StatusDigital = "L2";
        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            StatusDigital = "R2";
        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            StatusDigital = "Share";
        }
        if (Input.GetKeyDown("joystick button 7"))
        {
            StatusDigital = "Option";
        }
        if (Input.GetKeyDown("joystick button 8"))
        {
            StatusDigital = "TouchPad";
        }
        if (Input.GetKeyDown("joystick button 10"))
        {
            StatusDigital = "R3";
        }
        if (Input.GetKeyDown("joystick button 11"))
        {
            StatusDigital = "L3";
        }
        if (Input.GetKeyDown("joystick button 12"))
        {
            StatusDigital = "PS";
        }
        if (Input.GetKeyDown("joystick button 13"))
        {
            StatusDigital = "○";
        }
        if (Input.GetKeyDown("joystick button 14"))
        {
            StatusDigital = "R1";
        }

        StatusText.GetComponent<TextMesh>().text = StatusDigital;


        //Left Stick
        //1:→↓
        //-1:←↑
        float LeftStick_X = Input.GetAxis("LeftAnalogStick_X");
        float LeftStick_Y = Input.GetAxis("A");

        //Right Stick
        //1:→↓
        //-1:←↑
        float RightStick_X = Input.GetAxis("B");
        float RightStick_Y = Input.GetAxis("C");

        //L2|R2Trigger
        //1:Push
        //-1:Release
        float R2Trigger = Input.GetAxis("RightAnalogStick_X");
        float L2Trigger = Input.GetAxis("LeftAnalogStick_Y");


        //Dpad
        //1:↑→
        //-1:↓←
        float Dpad_X = Input.GetAxis("L2Trigger");
        float Dpad_Y = Input.GetAxis("R2Trigger");

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
