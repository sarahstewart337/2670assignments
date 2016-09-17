using UnityEngine;
using System.Collections;

public class IfSwitch : MonoBehaviour
{

    public int food = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            satisfyHunger();
        }
    }

    void satisfyHunger()
    {
        food = Random.Range(1, 4);

        switch (food)
        {

            case 1:
                Debug.Log("You found a banana");
                break;
            case 2:
                Debug.Log("You found an apple");
                break;
            case 3:
                Debug.Log("You found a donut");
                break;
            case 4:
                Debug.Log("You found a pear");
                break;


        }
    }
    }
