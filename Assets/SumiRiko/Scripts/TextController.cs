using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    private TextMeshProUGUI errorRemoveDebris;
    
    public GameObject debris;
    public GameObject feedback;

    // Start is called before the first frame update
    void Start()
    {
        errorRemoveDebris = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (debris.gameObject.CompareTag("Debris"))
        {
            errorRemoveDebris.text = "Please Remove Debris Before Entering Object Into Socket";
        }
    }
}
