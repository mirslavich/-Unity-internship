using System.Collections;
using TMPro;
using UnityEngine;

public class Display : MonoBehaviour, IShow
{
    [SerializeField] private TextMeshProUGUI _textMeshByClick;
    [SerializeField] private TextMeshProUGUI _textMeshByTime;
    public TextMeshProUGUI TextMeshByClick => _textMeshByClick;
    private  string _someMessage = "Hello World";
    private  string _defaultMessage = "***********";
    void Start()
    {
        if (_textMeshByClick==null || _textMeshByTime==null)
        {
            Debug.Log("Text not exist");
        }
        StartCoroutine(CoroutineTimer());
    }
     IEnumerator CoroutineTimer()
    {
        while (true)
        {
            ShowText(_textMeshByTime);
            yield return new WaitForSeconds(1);
            _textMeshByTime.text = _defaultMessage;
            yield return new WaitForSeconds(2);
        }
    }
     
    public void ShowText(TextMeshProUGUI someText)
    {
        someText.text = _someMessage;
    }
}