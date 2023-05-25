using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class button3 : MonoBehaviour
{
    public int plusAmount = 3;

    public int result = 0;

  

    public void OnButtononClick()
    {
        result += plusAmount;
    }
}
