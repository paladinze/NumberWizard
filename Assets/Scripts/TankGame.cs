using System;
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
    ManageState();
  }

  private void ManageState()
  {
      var nextStates = currState.GetNextStates();
      if (Input.GetKeyDown(KeyCode.Alpha1)) {
          currState = nextStates[0];
      }
      if (Input.GetKeyDown(KeyCode.Alpha2)) {
          currState = nextStates[1];
      }
      textComponent.text = currState.GetStoryText();
  }
}
