using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAgents : MonoBehaviour
{
    private bool alreadyTriggered = false;
    [SerializeField] GameObject agent;
    void OnTriggerEnter(){
        if (!alreadyTriggered){
            Instantiate(agent, gameObject.transform.position, gameObject.transform.rotation);
            alreadyTriggered = true;          
        }
    }
}
