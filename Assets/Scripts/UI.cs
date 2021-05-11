using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
   public Text healthText;
    public Text AmmoText;

    private void Start()
    {
        healthText.text = "100";
        AmmoText.text = "50";
    }


    private void Update()
    {
        
    }

}
