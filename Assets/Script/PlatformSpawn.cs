using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] Platform;
    
    MovePlatform movePlatform;
    public GameObject move;

    PlayerController playerController;
    public GameObject playerCont;
    public void Start()
    {
        playerCont = GameObject.FindGameObjectWithTag("Player");
        playerController = playerCont.GetComponent<PlayerController>();

        move = GameObject.FindGameObjectWithTag("movePlatform");
        movePlatform = move.GetComponent<MovePlatform>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(Platform[Random.Range(0, Platform.Length)], new Vector3(transform.position.x, transform.position.y - 3, transform.position.z + movePlatform.ForwardPlatform),Quaternion.identity);
             


            movePlatform.ForwardPlatform += 0.2f;
            playerController.timestartSpeed += 8f;
            playerController.moveSpeed += 0.8f;

        }
    }
   
}
