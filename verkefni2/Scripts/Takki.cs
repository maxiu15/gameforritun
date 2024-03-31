using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Takki : MonoBehaviour
{
    public TextMeshProUGUI texti;
   
    public void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex==3) // við erum að búa til hnapp fyrir lokaatriðin
        {
            texti.text = "Lokastig " + PlayerMovment.count.ToString();
        }
        
    }
    public void Byrja() // við hleðum 1. lvl
    {
        SceneManager.LoadScene(1);
    }
    public void Endir() // við hleðum upphafssenuna
    {
        SceneManager.LoadScene(0);
        PlayerMovment.count = 0;
    }
    
}
