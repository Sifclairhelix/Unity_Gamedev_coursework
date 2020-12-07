using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneswitch1 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<playercollectitems>().collectables >= 4)
        {
            SceneManager.LoadScene(2);
        }
    }
}
