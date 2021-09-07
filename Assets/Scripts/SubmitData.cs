using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Class to submit all the settings data into a string playerpref by serializing the settingsData into JSON object
/// </summary>
public class SubmitData : MonoBehaviour
{
	[SerializeField] GameObject LanguagesPanel;
	[SerializeField] GameObject GraphicsPanel;
	[SerializeField] GameObject SettingsButton;
	[SerializeField] Toggle ControlsToggle;
	[SerializeField] ToggleController Sound_Toggle;
	[SerializeField] ToggleController Music_Toggle;
	public string jsonData;
	

	public void StoreData()
	{
		try
		{
			SettingsData finalData = new SettingsData();

			finalData.controls = new Controls();

			finalData.controls.hands = ToggleControl.settingsData.controls.hands;
			finalData.controls.musicOn = Music_Toggle.isOn;
			finalData.controls.soundOn = Sound_Toggle.isOn;
			finalData.controls.steeringControl = ToggleControl.settingsData.controls.steeringControl;

			finalData.languages = new Languages();

			finalData.languages.language = ToggleControl.settingsData.languages.language;

			finalData.graphics = new Graphics();

			finalData.graphics.antiAliasing = ToggleControl.settingsData.graphics.antiAliasing;
			finalData.graphics.drawDistance = ToggleControl.settingsData.graphics.drawDistance;
			finalData.graphics.preset = ToggleControl.settingsData.graphics.preset;
			finalData.graphics.reflections = ToggleControl.settingsData.graphics.reflections;
			finalData.graphics.resolution = ToggleControl.settingsData.graphics.resolution;
			finalData.graphics.shadow = ToggleControl.settingsData.graphics.shadow;
			finalData.graphics.shadowDistance = ToggleControl.settingsData.graphics.shadowDistance;
			finalData.graphics.vSync = ToggleControl.settingsData.graphics.vSync;

			jsonData = JsonUtility.ToJson(finalData);
			PlayerPrefs.SetString("jsonData", jsonData);
		}

		catch(NullReferenceException e)
		{
			Debug.LogWarning($"Exception Caught {e}");
			LanguagesPanel.SetActive(true);
			LanguagesPanel.SetActive(false);

			GraphicsPanel.SetActive(true);
			GraphicsPanel.SetActive(false);

			StoreData();
		}

	}

	public void DisableSettings()
	{
		ControlsToggle.isOn = true;
		transform.parent.gameObject.SetActive(false);
		SettingsButton.SetActive(true);
	}
}
