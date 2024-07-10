using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    public DemonKing demonKingHealth;
    public GameObject AreaExit;
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Update()
    {
        Debug.Log(demonKingHealth.enemyHealth.currentHealth);
        if(playerController.CurrentScene == 5)
        {
           
            
        }
        //if(demonKingHealth = null)
        //return;
        if(demonKingHealth.enemyHealth.currentHealth <= 0)
        {
            AreaExit.SetActive(true);
            
        }
    }

    void Awake()
    {
        //demonKingHealth = GameObject.Find("DemonKing").GetComponent<DemonKing>();
        //AreaExit = GameObject.Find("AreaExit_Scene4");
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
}
