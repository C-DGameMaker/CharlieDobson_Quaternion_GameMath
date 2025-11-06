using UnityEngine;

public class CubeLook : MonoBehaviour
{
    public GameObject child;
    public Transform startPos;
    public Vector3 startPosVect;

    public GameObject target;
    private Vector3 targetPos;

    public GameObject upTarget;
    private Vector3 upTargetPos;

    public float time = 0.0f;
    void Start()
    {
        
        child.transform.position = transform.position + transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        transform.rotation = Quaternion.Slerp(startPos.rotation, Quaternion.LookRotation(upTarget.transform.position - transform.position), time);

    }
}
