using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpointnew : MonoBehaviour
{
    private Gamemaster gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<Gamemaster>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gm.lastCheckpointPos = transform.position;
        }
    }
}
