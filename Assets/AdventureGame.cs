using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text textComponent;
    [SerializeField] private State startingState;

    private State _state;
    
    // Start is called before the first frame update
    void Start()
    {
        _state = startingState;
        textComponent.text = _state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
