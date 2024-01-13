using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Display Display;
    private Button _button;
    
    void Start()
    {
        _button = GetComponent<Button>();
        if (_button == null)
        {
            Debug.Log("Button is not exist");
            return;
        }
        _button.onClick.AddListener(() => Display.ShowText(Display.TextMeshByClick));
    }
}
