using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int A;
    public int B;
    public string Resultadd;
    public string Resultdel;
    public string Resultdiv;
    public string Resultmultiplec;

    private void OnValidate()
    {
        Call(A, B); 
    }

    private void Call(int a, int b)
    {
       Resultadd = $"{a}+{b}={Add(a, b)}";
       Resultdel = $"{a}-{b}={del(a, b)}";
       Resultdiv = $"{a}/{b}={div(a, b)}";
       Resultmultiplec = $"{a}*{b}={multiplec(a, b)}";
    }
    private int Add(int a, int b)
    {
        return a + b;
    }
    private int del(int a, int b)
    {
        return a - b;
    }
    private int div(int a, int b)
    {
        return a / b;
    }
    private int multiplec (int a, int b)
    {
        return a * b;
    }
}
