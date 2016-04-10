using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class door : MonoBehaviour {
    public Text txt;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("text=" + txt.text);
            txt.text = "I need coffee first.";
        }
    }
}
