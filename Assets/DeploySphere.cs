using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeploySphere : MonoBehaviour
{

    public GameObject spherePrefab;
    public GameObject cubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(sphereSpawnCall());
    }

    IEnumerator sphereSpawnCall()
    {
        yield return new WaitForSeconds(4f);
        while (true)
        {
            if (EndScript.gameOver)
            {
                EndScript.displayend();
                yield return new WaitForSeconds(4f);
                break;
            }
            else
            {
                yield return new WaitForSeconds(Random.Range(0.5f, 2f));
                spawnSphere();
                yield return new WaitForSeconds(Random.Range(0.5f, 2f));
                spawnCube();
            }
        }
        UnityEditor.EditorApplication.isPlaying = false; //Application.Quit();
    }

    private void spawnSphere()
    {
        GameObject a = Instantiate(spherePrefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(-0.2f,0.2f), Random.Range(-0.2f, 0.2f), 3);
    }

    private void spawnCube()
    {
        GameObject a = Instantiate(cubePrefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f), 3);
    }
}