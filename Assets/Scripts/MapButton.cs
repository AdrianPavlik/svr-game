using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapButton : MonoBehaviour
{

    public Image mapImage;

    public void ButtonPress()
    {
        Debug.Log("BUTTON PRESSED");
        mapImage.enabled = !mapImage.enabled;
    }

    // Start is called before the first frame update
    void Start()
    {
        mapImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
