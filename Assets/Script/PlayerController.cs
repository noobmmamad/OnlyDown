using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] Rigidbody playerrb;
    [SerializeField] public float moveSpeed;
    [SerializeField] float moveSpeedlef;
    [SerializeField] float startSpeed;

    [SerializeField]public float timestartSpeed;
    [SerializeField] float timestartSpeedCounter;


    public bool leftb;
    public bool rightb;
    // Start is called before the first frame update
    void Start()
    {
       
    }
   
    public  void leftDown()
    {
        leftb = true;
    }
    public void leftUp()
    {
        leftb = false;
    }
    public void rightDown()
    {
        rightb = true;
    }
    public void rightUp()
    {
        rightb = false;
    }
    // Update is called once per frame
    void Update()
    {
       
      if(timestartSpeedCounter <= timestartSpeed)
        {
            playerrb.AddForce(Vector3.forward * startSpeed);
            timestartSpeedCounter += 1;
        }

        if (leftb == true)
        {
            playerrb.AddForce(Vector3.right * moveSpeedlef);
        }
        if (rightb == true)
        {
            playerrb.AddForce(Vector3.left * moveSpeedlef);
        }
    }
}
