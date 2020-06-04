using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setTextAndColour(string s, Color colour){
        GetComponent<Text>().text = s;
        GetComponent<Text>().color = colour;
    }
}
