using UnityEngine;

public class MainCanvas : MonoBehaviour
{    
    private Canvas _canvas;

    // Start is called before the first frame update
    void Start()
    {
        _canvas = GetComponent<Canvas>();
    }

    public void AddChild(MonoBehaviour monoBehaviour)
    {
        AddChild(monoBehaviour.GetComponent<RectTransform>());
    }

    public void AddChild(RectTransform rectTransform)
    {
        rectTransform.SetParent(this.transform, false);
    }
}
