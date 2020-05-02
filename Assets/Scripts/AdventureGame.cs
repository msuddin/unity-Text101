using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text storyText;
    [SerializeField] State startingState;
    [SerializeField] Text numberOfSteps;

    State currentStoryState;
    int currentNumberOfSteps;

    void Start()
    {
        currentStoryState = startingState;
        storyText.text = currentStoryState.GetStoryText();

        currentNumberOfSteps = 0; 
        numberOfSteps.text = "Current Number of steps: " + currentNumberOfSteps;
    }
    
    void Update()
    {
        ManageStoryState();
        ManageCurrentNumberOfSteps();
    }

    private void ManageStoryState()
    {
        var nextStoryStates = currentStoryState.GetStoryStates();
        
        for (int index = 0; index < nextStoryStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                currentStoryState = nextStoryStates[index];
                currentNumberOfSteps++;
            }
        }

        storyText.text = currentStoryState.GetStoryText();
    }

    private void ManageCurrentNumberOfSteps()
    {
        if (currentStoryState.HasGameEnded())
        {
            currentNumberOfSteps = 0;
        }

        numberOfSteps.text = "Current Number of steps: " + currentNumberOfSteps;
    }
}
