using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class to set values of the Custom Preset value in the Graphics Panel.
/// </summary>
public class CustomPreset : MonoBehaviour
{
	[SerializeField] Toggle CustomPresetToggle;
	[SerializeField] Slider ResolutionSlider;
	[SerializeField] Slider ShadowDistanceSlider;
	[SerializeField] Slider DrawDistanceSlider;

	public static bool changeToCustom = false;

	public void SetToCustomPreset()
	{
		if (!CustomPresetToggle.isOn)
			CustomPresetToggle.isOn = true;

		ToggleControl.settingsData.graphics.preset = Preset.Custom;
		ToggleControl.settingsData.graphics.resolution = (int) ResolutionSlider.value;
		ToggleControl.settingsData.graphics.shadowDistance = (int) ShadowDistanceSlider.value;
		ToggleControl.settingsData.graphics.drawDistance = (int) DrawDistanceSlider.value;

	}

	public void SetToCustomPresetFromToggle()
	{
		if (!GetComponent<Toggle>().isOn)
		{		
			if (!CustomPresetToggle.isOn)
				CustomPresetToggle.isOn = true;

			ToggleControl.settingsData.graphics.preset = Preset.Custom;
			ToggleControl.settingsData.graphics.resolution = (int)ResolutionSlider.value;
			ToggleControl.settingsData.graphics.shadowDistance = (int)ShadowDistanceSlider.value;
			ToggleControl.settingsData.graphics.drawDistance = (int)DrawDistanceSlider.value;

		}
	}

	public void SetCustomShadow()
	{
		if (!GetComponent<Toggle>().isOn)
			ToggleControl.settingsData.graphics.shadow = (Shadow)Enum.Parse(typeof(Shadow), this.name);
	}

	public void SetCustomAntiAliasing()
	{
		if (!GetComponent<Toggle>().isOn)
			ToggleControl.settingsData.graphics.antiAliasing = (AntiAliasing)Enum.Parse(typeof(AntiAliasing), this.name);
	}

	public void SetCustomVSync()
	{
		if (!GetComponent<Toggle>().isOn)
			ToggleControl.settingsData.graphics.vSync = (VSync)Enum.Parse(typeof(VSync), this.name);
	}

	public void SetCustomReflections()
	{
		if (!GetComponent<Toggle>().isOn)
			ToggleControl.settingsData.graphics.reflections = (Reflections)Enum.Parse(typeof(Reflections), this.name);
	}
	
}
