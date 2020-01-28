using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TankGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startState;

    State currState;

    // Start is called before the first frame update
    void Start()
    {
        currState = startState;
        textComponent.text = currState.GetStoryText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
