using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class enemigo : MonoBehaviour

{
    public GameObject target;
    public float speed;
    public float radiusAttack;
    public float radiusMovement;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
    }

    public void FollowTarget()
    {
        Vector3 dir = (target.transform.position - transform.position).normalized;

        if (Vector3.Distance(target.transform.position, transform.position) < radiusMovement)
        {
            if (Vector3.Distance(target.transform.position, transform.position) < radiusAttack)
            {
                Debug.Log("atacando >:l ");

            }
            else
            {
                transform.position += dir * speed * Time.deltaTime;


            }
        }
    }
}
        
