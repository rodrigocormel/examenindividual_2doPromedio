using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class button2 : MonoBehaviour
{
    public int plusAmount = 2;
  

    public int result = 0;
    // Start is called before the first frame update
    

    public void OnButtononClick()
    {
        result += plusAmount;
    }
}
