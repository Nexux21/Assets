using UnityEngine;

public class enemigo : MonoBehaviour
{
    public GameObject target;
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
        Vector3 targetPosition = target.transform.position;

    }
}
