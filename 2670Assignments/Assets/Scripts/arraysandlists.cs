using UnityEngine;
using System.Collections;

public class arraysandlists : MonoBehaviour
{
    public GameObject[] weapons;

	// Use this for initialization
	void Start ()
    {
        weapons = GameObject.FindGameObjectsWithTag("Weapon");

        for(int i =0; i <weapons.Length; i++)
        {
            Debug.Log("Weapon number " + i + " is named " +weapons[i].name);

        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
