using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Enter a number between 0-1000:");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("up arrow pressed");
        } else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Debug.Log("left arrow pressed");
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Return key pressed");
        }
    }
}
