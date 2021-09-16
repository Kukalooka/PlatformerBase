using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class set : MonoBehaviour
{
    Text instruction;
    void Start () {
        instruction = GetComponent<Text>();
    }

    void Update()
    {
        instruction.text = countup1.counter.ToString();
    }
}
