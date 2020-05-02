using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField] [TextArea(10, 15)] string storyText;
    [SerializeField] State[] storyStates;
    [SerializeField] bool hasGameEnded;


    public string GetStoryText()
    {
        return storyText;
    }
    
    public State[] GetStoryStates()
    {
        return storyStates;
    }

    public bool HasGameEnded()
    {
        return hasGameEnded;
    }
}
