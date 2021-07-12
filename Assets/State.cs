using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
     [TextArea(14, 10)] [SerializeField] private string storyText;
     [SerializeField] private State[] nextStates;
     internal string GetStateStory()
     {
          return storyText;
     }

     internal State[] GetNextStates()
     {
          return nextStates;
     }
}
