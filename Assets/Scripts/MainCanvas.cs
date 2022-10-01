using UnityEngine;

public class MainCanvas : MonoBehaviour
{    
    private Canvas _canvas;

    // Start is called before the first frame update
    void Start()
    {
        _canvas = GetComponent<Canvas>();
    }

}
