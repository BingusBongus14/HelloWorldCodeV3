using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text newText;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown("space"))
        {
            newText.text = "Hello, my name is Ethan Branham!";
        }
      if (Input.GetKey("escape"))
      {
          Application.Quit();
      }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
