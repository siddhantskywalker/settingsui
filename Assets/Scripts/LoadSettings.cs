using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Class to fetch all the previous settings data from json and assign it for Graphics Panel.
/// </summary>
public class LoadSettings : MonoBehaviour
{
	[SerializeField] GameObject SettingsPanel;
	[SerializeField] GameObject ControlsPanel;
	[SerializeField] GameObject LanguagesPanel;
	[SerializeField] GameObject GraphicsPanel;

	[SerializeField] Slider ResoultionSlider;
	[SerializeField] Slider ShadowDistanceSlider;
	[SerializeField] Slider DrawDistanceSlider;


	public string jsonData;
	public static SettingsData retrievedData;

	public void LoadPanel()
	{
		SettingsPanel.SetActive(true);
		gameObject.SetActive(false);
	}

	public void LoadData()
	{
		if(PlayerPrefs.HasKey("jsonData"))
		{
			LanguagesPanel.SetActive(true);
			GraphicsPanel.SetActive(true);

			jsonData = PlayerPrefs.GetString("jsonData");

			retrievedData = JsonUtility.FromJson<SettingsData>(jsonData);
			

			GameObject.Find(retrievedData.controls.steeringControl.ToString()).GetComponent<Toggle>().isOn = true;
			GameObject.Find("Sound_Toggle").GetComponent<ToggleController>().isOn = retrievedData.controls.soundOn;
			GameObject.Find("Music_Toggle").GetComponent<ToggleController>().isOn = retrievedData.controls.musicOn;
			GameObject.Find(retrievedData.controls.hands.ToString()).GetComponent<Toggle>().isOn = true;

			GameObject.Find(retrievedData.languages.language.ToString()).GetComponent<Toggle>().isOn = true;

			
			GameObject.Find(retrievedData.graphics.preset.ToString() + "_Preset").GetComponent<Toggle>().isOn = true;
			GameObject.Find(retrievedData.graphics.preset.ToString() + "_Preset").GetComponent<Toggle>().Select();
			
			ResoultionSlider.value = retrievedData.graphics.resolution;
			GameObject.Find(retrievedData.graphics.shadow.ToString()).GetComponent<Toggle>().isOn = true;
			ShadowDistanceSlider.value = retrievedData.graphics.shadowDistance;
			DrawDistanceSlider.value = retrievedData.graphics.drawDistance;
			GameObject.Find(retrievedData.graphics.antiAliasing.ToString()).GetComponent<Toggle>().isOn = true;
			GameObject.Find(retrievedData.graphics.vSync.ToString()).GetComponent<Toggle>().isOn = true;
			GameObject.Find(retrievedData.graphics.reflections.ToString()).GetComponent<Toggle>().isOn = true;
			


			LanguagesPanel.SetActive(false);
			GraphicsPanel.SetActive(false);
		}
	}

}
