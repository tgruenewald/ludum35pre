using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mug : MonoBehaviour {
    public Text txt;
    public Image redScreen;
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
            txt.text = "this is a mug";

            Debug.Log("Setting the transition");
            //redScreen.GetComponent<Animator>().SetTrigger("Transition");
            redScreen.GetComponent<Animation>().Play();
        }
    }

}
