using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarScript : MonoBehaviour
{

    //Storing our slider
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    //Created a function for setting the max health so that it doesnt need to be done in inspector
    public void MaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }

    //Creating a function for setting the health
    public void SetHealth(int health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
