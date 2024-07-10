using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonKing : MonoBehaviour
{
    public EnemyHealth enemyHealth;

    // Start is called before the first frame update
    void Awake()
    {
        enemyHealth = GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(enemyHealth.currentHealth);
    }
}
