using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    private TextMeshProUGUI errorRemoveDebris;

    // Start is called before the first frame update
    void Start()
    {
        errorRemoveDebris = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void UIFeedback()
    //{
    //    if (inRange.GetComponent<ObjectOrientationController>().inRange = false)
    //    {

    //    }
    //}
}
