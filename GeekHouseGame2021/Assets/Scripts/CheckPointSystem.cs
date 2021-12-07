using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Transform[] checkPoints;

    public int selectedCheckPoint = 0;

    void Update(){
        if (Input.GetKeyDown(KeyCode.M)){
            selectedCheckPoint += 1;
            if (selectedCheckPoint == checkPoints.Length) {
                selectedCheckPoint = 0;
            }
            Respawn();
        }
    }

    public void Respawn(){
        player.transform.position = checkPoints[selectedCheckPoint].position;
    }
}
