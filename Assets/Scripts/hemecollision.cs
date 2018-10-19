using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hemecollision : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "hemes")
        {
            Destroy(col.gameObject);
        }
    }
}
