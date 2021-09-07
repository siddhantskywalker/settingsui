using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Class to Initialise and set stored values of Languages Panel.
/// </summary>
public class InitializeLanguage : MonoBehaviour
{
    public void OnEnable()
    {
        if(GetComponent<Toggle>().isOn)
		    GetComponent<ToggleControl>().LanguageSelector(gameObject.name);
    }
}
