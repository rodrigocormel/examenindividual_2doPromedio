using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SumResult : MonoBehaviour
{
    public button1 button1; 
    public button2 button2; 
    public button3 button3; 
    public Text sum;

    private void Update()
    {
        
        int n1 = button1.result;
        int n2 = button2.result;
        int n3 = button3.result;

        int resultTotal = n1 + n2 + n3;
        string resultado = resultTotal.ToString();

       
        sum.text = resultado;
    }
}
