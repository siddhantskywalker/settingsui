using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Class to assign the value of text next to the sliders in Graphics Panel when the slider is Dragged.
/// </summary>
public class SliderText : MonoBehaviour
{
    [SerializeField] Text SliderValueText;

	public void ChangeSliderText()
	{
		SliderValueText.text = $"{GetComponent<Slider>().value}%";
	}
}
