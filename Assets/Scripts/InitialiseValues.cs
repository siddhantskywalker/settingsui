using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Class to Initialise and set stored values of Controls Panel.
/// </summary>
public class InitialiseValues : MonoBehaviour
{

    public void OnEnable()
    {   
        if (ToggleControl.settingsData == null)
        {
            ToggleControl.settingsData = new SettingsData();
            ToggleControl.settingsData.controls = new Controls();
        }

        if (GetComponent<Toggle>() && GetComponent<Toggle>().isOn)
        {
            if (this.name == "Steering")
                ToggleControl.settingsData.controls.steeringControl = SteeringControl.Steering;

            if(this.name == "Touch Pad")
                ToggleControl.settingsData.controls.steeringControl = SteeringControl.TouchPad;

            if(this.name == "Tilt")
                ToggleControl.settingsData.controls.steeringControl = SteeringControl.Tilt;

            if (this.name == "LeftSide")
                ToggleControl.settingsData.controls.hands = Hands.LeftSide;

            if (this.name == "RightSide")
                ToggleControl.settingsData.controls.hands = Hands.RightSide;

        }

        
        if (GetComponent<ToggleController>())
        {
            if (this.name == "Sound_Toggle")
                ToggleControl.settingsData.controls.soundOn = GetComponent<ToggleController>().isOn;

            if (this.name == "Music_Toggle")
                ToggleControl.settingsData.controls.musicOn = GetComponent<ToggleController>().isOn;
        }
    }

}
