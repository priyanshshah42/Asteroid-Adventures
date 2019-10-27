using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScript : MonoBehaviour
{
    static Text end;
    public static bool gameOver;

    public static void displayend()
    {
        end.text = "GAME OVER";
        
    }
    // Start is called before the first frame update
    void Start()
    {
        end = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
