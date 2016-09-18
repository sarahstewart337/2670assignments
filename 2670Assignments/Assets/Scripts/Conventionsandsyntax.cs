using UnityEngine;
using System.Collections;

public class Conventionsandsyntax : MonoBehaviour
{

    void Start()
    {
        Debug.Log(transform.position.x);

        if (transform.position.y <= 10f)
        {
            Debug.Log("I seem to be falling forever...");
        }
    }
}