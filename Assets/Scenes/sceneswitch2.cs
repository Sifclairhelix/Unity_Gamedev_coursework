using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitch2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<playercollectitems>().collectables >= 8)
        {
            SceneManager.LoadScene(4);
        }
    }
}
