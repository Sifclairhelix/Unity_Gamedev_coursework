using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawnPoint : MonoBehaviour
{
    public float spawnRange = 40.0f;
    public GameObject enemy;
    public int NumEenemy = 3;
    public bool isGen = true;

    private Transform target;
    private GameObject currentEnemy;
    private bool isOutsideRange = true;
    private Vector3 distanceToPlayer;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = transform.position - target.position;
        if (distanceToPlayer.magnitude < spawnRange && isGen)
        {
            NumEenemy -= 1;
            //if (!currentEnemy)
            //{
            currentEnemy = Instantiate(enemy, transform.position, transform.rotation) as GameObject;
            //}
            //isOutsideRange = false;
            if (NumEenemy == 0)
            {
                isGen = false;
            }
        }
        //else
        //{
        //    if (currentEnemy)
        //    {
        //        Destroy(currentEnemy);
        //    }
        //}
        isOutsideRange = true;
    }
}
