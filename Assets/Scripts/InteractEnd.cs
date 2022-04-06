using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class InteractEnd : MonoBehaviour
{

    [SerializeField] private float maxDistanceFromObject; // Shortens the ray distance
    [SerializeField] private GameObject endDisplay;
    [SerializeField] private TextMeshProUGUI endDescription;

    //Function to run when being hovered over, should make the object glow
    //Will later possibly do more
    public void HoverOver()
    {
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }

    public void HoverEnd()
    {
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");

    }

    public void SelectItem()
    {
        endDisplay.SetActive(true);

        endDescription.text = "Oh why did you click that???";
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
