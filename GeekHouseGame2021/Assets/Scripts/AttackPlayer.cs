using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    private GameObject player;
    // [SerializeField] float vitesse;
    void Start(){
        if (player == null)
        player = GameObject.FindWithTag("Player");
    }
    void Update(){
        gameObject.transform.LookAt(player.transform);
        // Vector3 tempVect = new Vector3(1, 0, 0);
        // tempVect = tempVect * vitesse * Time.deltaTime;
        // gameObject.GetComponent<Rigidbody>().MovePosition(transform.position + tempVect);
    }
    void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){
            gameObject.GetComponent<Animator>().SetTrigger("Attack");
            Debug.Log("ggdegfg");
        }
    }
}
