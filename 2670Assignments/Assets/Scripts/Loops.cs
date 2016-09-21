using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour
{
    int numOfStarsInPouch = 5;

    // Use this for initialization
    void Start ()
    {
	    while(numOfStarsInPouch > 0)
        {
            Debug.Log("I caught a star!");
            numOfStarsInPouch--;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
