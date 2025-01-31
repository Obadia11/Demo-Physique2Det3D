using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionSuperposition : MonoBehaviour
{
    void OnTriggerEnter(Collider autre){
        print(autre.gameObject.name);
    }

}
