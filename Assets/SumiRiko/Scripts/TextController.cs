using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    //Attach this Script to the TEXT MESH PRO TEXT of the UI Pop-up

    private TextMeshProUGUI feedback;
    
    public GameObject debris;
    //Add the Debris GameObject in the Inspector

    // Start is called before the first frame update
    void Start()
    {
        feedback = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (debris.activeSelf)
        {
            feedback.text = "Please Remove Debris Before Entering Object Into Socket";
        }
        else
        {
            feedback.text = "Insert the Object Into the Socket";
        }
    }
}
