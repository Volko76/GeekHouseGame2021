using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerArea : MonoBehaviour
{
    [SerializeField]
    private CheckPointSystem checkPoint;

    private void OnTriggerEnter(Collider collider){
        checkPoint.Respawn();
    }
}
