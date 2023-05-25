using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class button : MonoBehaviour
{
    public int plusAmount = 1;
    public Text resultText;

    private int result = 0;
    // Start is called before the first frame update
    void Start()
    {
        resultText.text = result.ToString();
    }

    public void OnButtononClick()
    {
        result += plusAmount;

        resultText.text = result.ToString();
    }
}
