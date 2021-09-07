using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
/// <summary>
/// Class to change the text color of the toggle on select.
/// </summary>
public class ToggleText : MonoBehaviour
{
	[SerializeField] Color DefaultTextColor;
	[SerializeField] Color ClickedTextColor;

	public ToggleTypes Toggle;
	[SerializeField] GameObject Panel;

	private void OnEnable()
	{
		ChangeToggleText();
	}

	public void ChangeToggleText()
	{
		if (GetComponent<Toggle>().isOn)
		{
			GetComponentInChildren<Text>().color = ClickedTextColor;

			if (Toggle == ToggleTypes.Primary)
				Panel.SetActive(true);

			if (Toggle == ToggleTypes.Preset)
			{
				string capitalText;
				capitalText = GetComponentInChildren<Text>().text.ToUpper();
				GetComponentInChildren<Text>().text = capitalText;
			}
		}

		else
		{
			GetComponentInChildren<Text>().color = DefaultTextColor;

			if (Toggle == ToggleTypes.Primary)
				Panel.SetActive(false);

			if (Toggle == ToggleTypes.Preset)
			{
				string lowerText;
				lowerText = GetComponentInChildren<Text>().text.ToLower();
				GetComponentInChildren<Text>().text = char.ToUpper(lowerText[0]) + lowerText.Substring(1);
			}
		}
	}
}
