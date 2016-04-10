using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mug : MonoBehaviour {
    public Text txt;
    public Canvas canvas;
	Animator anim;


    // Use this for initialization
    void Start () {
		anim = canvas.GetComponent<Animator>();
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
			anim.SetTrigger ("TextOn");

            Debug.Log("Setting the transition");
            anim.SetTrigger("Transition");
  
        }
    }

}
