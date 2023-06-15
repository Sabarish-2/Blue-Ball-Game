using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class H_M : MonoBehaviour
{
    public static H_M instance1;
    public TextMeshProUGUI text;
    //public int H;

    // Start is called before the first frame update
    void Start()
    {
        if (instance1 == null)
        {
            instance1 = this;
        }
    }

    public void ChangeH(int health)
    {
       text.text = "X " + health.ToString();
    }
}