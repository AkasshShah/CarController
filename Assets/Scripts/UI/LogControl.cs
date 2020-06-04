using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogControl : MonoBehaviour
{

    public GameObject itemTemplate;
    private List<GameObject> logs;
    public Transform content;

    // Start is called before the first frame update
    void Start()
    {
        logs = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void logMsg(string s, Color colour)
    {
        if (logs.Count >= 4){
            GameObject temp = logs[0];
            Destroy(temp.gameObject);
            logs.Remove(temp);
        }
        GameObject newLog = Instantiate(itemTemplate) as GameObject;
        newLog.SetActive(true);
        newLog.GetComponentInChildren<LogItem>().setTextAndColour(s, colour);
        newLog.transform.SetParent(content, false);
        logs.Add(newLog.gameObject);
    }
}
