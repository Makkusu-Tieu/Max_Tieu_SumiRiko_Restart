using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    private TextMeshProUGUI feedback;
    
    public GameObject debris;

    // Start is called before the first frame update
    void Start()
    {
        feedback = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (debris.gameObject.CompareTag("Debris"))
        {
            feedback.text = "Please Remove Debris Before Entering Object Into Socket";
        }
        else
        {
            feedback.text = "Insert the Object Into the Socket";
        }
    }
}
