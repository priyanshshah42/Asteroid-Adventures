using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesScript : MonoBehaviour
{
    static Text lives;
   

    // Start is called before the first frame update
    void Start()
    {
        lives = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void LostLife()
    {
        if (lives.text.Length >= 2)
            lives.text = lives.text.Substring(0, lives.text.Length - 2);
        else
        {
            EndScript.gameOver = true;
        }
    }
}
