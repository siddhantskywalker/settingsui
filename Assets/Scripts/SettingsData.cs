using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Schema of whole settings in a Class, to be used for serializing the settings data into a single JSON object.
/// </summary>
[Serializable]
public class SettingsData
{
	public Controls controls;
	public Languages languages;
	public Graphics graphics;
}

[Serializable]
public class Controls
{
	public SteeringControl steeringControl;
	public bool soundOn;
	public bool musicOn;
	public Hands hands;
}

[Serializable]
public class Languages
{
	public Language language;
}

[Serializable]
public class Graphics
{
	public Preset preset;
	public int resolution;
	public Shadow shadow;
	public int shadowDistance;
	public int drawDistance;
	public AntiAliasing antiAliasing;
	public VSync vSync;
	public Reflections reflections;
}

[Serializable]
public enum SteeringControl
{
	Steering,
	TouchPad,
	Tilt
}

[Serializable]
public enum Hands
{
	LeftSide,
	RightSide
}

[Serializable]
public enum Language
{
	Dutch, English, French, Chinese,
	German, Italian, Portugese, Danish,
	Espanol, Svenska, Japanese, Vietnamese,
	Korean, Russian, Arabic, Turkish
}

[Serializable]
public enum Preset
{
	Automatic,
	Low,
	Medium,
	High,
	Advanced,
	Custom
}

[Serializable]
public enum Shadow
{
	Shadow_Low,
	Shadow_Med,
	Shadow_High,
	Shadow_Off
}

[Serializable]
public enum AntiAliasing
{
	TwoX,
	FourX,
	Off
}

[Serializable]
public enum VSync
{
	VSync_On,
	VSync_Off
}

[Serializable]
public enum Reflections
{
	Reflections_On,
	Reflections_Off
}

