using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Transform goTo;

    void OnTriggerEnter(){
        player.transform.position = goTo.position;
    }



}
