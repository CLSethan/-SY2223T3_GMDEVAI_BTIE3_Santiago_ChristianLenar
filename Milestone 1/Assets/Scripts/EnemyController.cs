using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform target;
    public float speed = 5;
    public float rotSpeed = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 lookAtGoal = new Vector3(target.position.x, this.transform.position.y, target.position.z);
        Vector3 direction = lookAtGoal - transform.position;
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);

        if(Vector3.Distance(lookAtGoal, transform.position)>1)
        {
            transform.Translate(0,0,speed*Time.deltaTime);
        }
    }
}
