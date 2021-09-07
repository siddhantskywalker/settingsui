using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Class to assign values of control panel settings to the settingsData object (Later to be serialized) on selecting the toggle.
/// </summary>
public class ToggleControl : MonoBehaviour
{
	public static SettingsData settingsData;
	public void SteeringControls(string steeringControlsEnum)
	{
		if (settingsData == null)
		{
			settingsData = new SettingsData();
			settingsData.controls = new Controls();
		}

		if (GetComponent<Toggle>().isOn)
			settingsData.controls.steeringControl = (SteeringControl)Enum.Parse(typeof(SteeringControl), steeringControlsEnum);
	}

	public void HandsControl(string handsEnum)
	{
		if (settingsData == null)
		{
			settingsData = new SettingsData();
			settingsData.controls = new Controls();
		}

		if (GetComponent<Toggle>().isOn)
			settingsData.controls.hands = (Hands)Enum.Parse(typeof(Hands), handsEnum);
	}

	public void LanguageSelector(string languageEnum)
	{
		if (settingsData == null)
			settingsData = new SettingsData();
		
		if(settingsData.languages == null)
			settingsData.languages = new Languages();

		if (GetComponent<Toggle>().isOn)
			settingsData.languages.language = (Language)Enum.Parse(typeof(Language),languageEnum);
	}
}
