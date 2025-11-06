using UnityEngine;

public class CubeLook : MonoBehaviour
{
    public GameObject child;
    public Vector3 startPos;

    public GameObject target;
    public Vector3 targetPos;

    public GameObject upTarget;
    public Vector3 upTargetPos;
    void Start()
    {
        startPos = transform.position;
        child.transform.position = startPos + transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        upTargetPos = upTarget.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(upTargetPos, Vector3.forward);

        transform.rotation = rotation;
    }
}
