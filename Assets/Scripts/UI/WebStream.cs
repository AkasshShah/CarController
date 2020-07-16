using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WebStream : MonoBehaviour
{
    //public string uri = "http://192.168.0.102:42068/stream.mjpg"; //url for example
    public Texture2D cam;
    [SerializeField]
    private Image sp;
    public void Start()
    {
        cam = new Texture2D(640, 480, TextureFormat.RGB24, false);
        StartCoroutine(Fetch());
    }
    public IEnumerator Fetch()
    {
        while (true)
        {
            Debug.Log("loading... " + Time.realtimeSinceStartup);
            WWWForm form = new WWWForm();
            WWW www = new WWW("http://192.168.0.102:42068/stream.mjpg");
            yield return www;
            if (!string.IsNullOrEmpty(www.error))
                throw new UnityException(www.error);
            //www.LoadImageIntoTexture(sprite);
        }
    }
    public void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), cam);
    }
}