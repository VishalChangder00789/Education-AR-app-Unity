using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public GameObject[] A_prefabs;
    public Transform spawnerObject;
    private float speed=50.0f;

    bool instantiate = false;
    GameObject currentObject;
    GameObject previousObject;
   
    void Update()
    {
        currentObject.transform.Rotate(new Vector3(35,12,25), Time.deltaTime*speed);
    }
    public void onButtonRight()
    {
        if (instantiate == true)
        {
            ///Destroy the previous object
            currentObject.SetActive(false);
        }
        ///Instantiate a new one.
        int random = Random.Range(0, A_prefabs.Length);
        currentObject = Instantiate(A_prefabs[random], spawnerObject.position, spawnerObject.rotation);
        currentObject.transform.SetParent(spawnerObject.transform);
        previousObject = currentObject;
        instantiate = true;
    }



    /// <summary>
    /// will check later
    /// 
    /// </summary>
    public void onButtonLeft()
    {
        if (instantiate == true)
        {
            ///Destroy the previous object
            currentObject.SetActive(false);
        }
        currentObject=Instantiate(previousObject, spawnerObject.position, spawnerObject.rotation);
    }


}
