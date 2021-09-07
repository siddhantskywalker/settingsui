using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
/// <summary>
/// Class to Store the Graphics Panel data to the static object.
/// </summary>
public class GraphicsPreset : MonoBehaviour,ISelectHandler
{

    [SerializeField] Slider ResolutionSlider;
    [SerializeField] Slider ShadowDistanceSlider;
    [SerializeField] Slider DrawDistanceSlider;

	public void OnEnable()
	{
        if (GetComponent<Toggle>().isOn)
            GetComponent<Toggle>().Select();
	}

	public void OnSelect(BaseEventData baseEventData)
	{
        if (ToggleControl.settingsData.graphics == null)
            ToggleControl.settingsData.graphics = new Graphics();

        if (GetComponent<ToggleText>().Toggle == ToggleTypes.Preset && gameObject.name == "Automatic_Preset")
        {
            ToggleControl.settingsData.graphics.preset = Preset.Automatic;
            ToggleControl.settingsData.graphics.resolution = 80;
            ToggleControl.settingsData.graphics.shadow = Shadow.Shadow_High;
            ToggleControl.settingsData.graphics.shadowDistance = 75;
            ToggleControl.settingsData.graphics.drawDistance = 70;
            ToggleControl.settingsData.graphics.antiAliasing = AntiAliasing.TwoX;
            ToggleControl.settingsData.graphics.vSync = VSync.VSync_Off;
            ToggleControl.settingsData.graphics.reflections = Reflections.Reflections_On;
        }

        if (GetComponent<ToggleText>().Toggle == ToggleTypes.Preset && gameObject.name == "Low_Preset")
		{
            ToggleControl.settingsData.graphics.preset = Preset.Low;
            ToggleControl.settingsData.graphics.resolution = 50;
            ToggleControl.settingsData.graphics.shadow = Shadow.Shadow_Low;
            ToggleControl.settingsData.graphics.shadowDistance = 60;
            ToggleControl.settingsData.graphics.drawDistance = 40;
            ToggleControl.settingsData.graphics.antiAliasing = AntiAliasing.Off;
            ToggleControl.settingsData.graphics.vSync = VSync.VSync_Off;
            ToggleControl.settingsData.graphics.reflections = Reflections.Reflections_Off;
		}

        if (GetComponent<ToggleText>().Toggle == ToggleTypes.Preset && gameObject.name == "Medium_Preset")
        {
            ToggleControl.settingsData.graphics.preset = Preset.Medium;
            ToggleControl.settingsData.graphics.resolution = 60;
            ToggleControl.settingsData.graphics.shadow = Shadow.Shadow_Med;
            ToggleControl.settingsData.graphics.shadowDistance = 70;
            ToggleControl.settingsData.graphics.drawDistance = 50;
            ToggleControl.settingsData.graphics.antiAliasing = AntiAliasing.Off;
            ToggleControl.settingsData.graphics.vSync = VSync.VSync_Off;
            ToggleControl.settingsData.graphics.reflections = Reflections.Reflections_On;
        }

        if (GetComponent<ToggleText>().Toggle == ToggleTypes.Preset && gameObject.name == "High_Preset")
        {
            ToggleControl.settingsData.graphics.preset = Preset.High;
            ToggleControl.settingsData.graphics.resolution = 75;
            ToggleControl.settingsData.graphics.shadow = Shadow.Shadow_High;
            ToggleControl.settingsData.graphics.shadowDistance = 80;
            ToggleControl.settingsData.graphics.drawDistance = 70;
            ToggleControl.settingsData.graphics.antiAliasing = AntiAliasing.TwoX;
            ToggleControl.settingsData.graphics.vSync = VSync.VSync_Off;
            ToggleControl.settingsData.graphics.reflections = Reflections.Reflections_On;
        }

        if (GetComponent<ToggleText>().Toggle == ToggleTypes.Preset && gameObject.name == "Advanced_Preset")
        {
            ToggleControl.settingsData.graphics.preset = Preset.Advanced;
            ToggleControl.settingsData.graphics.resolution = 90;
            ToggleControl.settingsData.graphics.shadow = Shadow.Shadow_High;
            ToggleControl.settingsData.graphics.shadowDistance = 90;
            ToggleControl.settingsData.graphics.drawDistance = 80;
            ToggleControl.settingsData.graphics.antiAliasing = AntiAliasing.FourX;
            ToggleControl.settingsData.graphics.vSync = VSync.VSync_On;
            ToggleControl.settingsData.graphics.reflections = Reflections.Reflections_On;
        }

        if (GetComponent<ToggleText>().Toggle == ToggleTypes.Preset && gameObject.name == "Custom_Preset")
        {
            ToggleControl.settingsData.graphics.preset = Preset.Custom;
            ToggleControl.settingsData.graphics.resolution = 95;
            ToggleControl.settingsData.graphics.shadow = Shadow.Shadow_High;
            ToggleControl.settingsData.graphics.shadowDistance = 95;
            ToggleControl.settingsData.graphics.drawDistance = 95;
            ToggleControl.settingsData.graphics.antiAliasing = AntiAliasing.FourX;
            ToggleControl.settingsData.graphics.vSync = VSync.VSync_On;
            ToggleControl.settingsData.graphics.reflections = Reflections.Reflections_On;
        }



        SetPresetValues
        (ToggleControl.settingsData.graphics.resolution,
        ToggleControl.settingsData.graphics.shadow,
        ToggleControl.settingsData.graphics.shadowDistance,
        ToggleControl.settingsData.graphics.drawDistance,
        ToggleControl.settingsData.graphics.antiAliasing,
        ToggleControl.settingsData.graphics.vSync,
        ToggleControl.settingsData.graphics.reflections);


    }

    public void SetPresetValues(int resolution, Shadow shadow, int shadowDistance, int drawDistance, AntiAliasing antiAliasing, VSync vSync, Reflections reflections)
	{
        ResolutionSlider.value = resolution;
        GameObject.Find(shadow.ToString()).GetComponent<Toggle>().isOn = true;
        ShadowDistanceSlider.value = shadowDistance;
        DrawDistanceSlider.value = drawDistance;
        GameObject.Find(antiAliasing.ToString()).GetComponent<Toggle>().isOn = true;
        GameObject.Find(vSync.ToString()).GetComponent<Toggle>().isOn = true;
        GameObject.Find(reflections.ToString()).GetComponent<Toggle>().isOn = true;
    }
}
