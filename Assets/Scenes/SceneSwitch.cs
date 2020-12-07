using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
     void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<playercollectitems>().collectables >= 5)
        {
            SceneManager.LoadScene(3);
        }
    }
}
