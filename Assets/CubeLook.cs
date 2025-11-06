using UnityEngine;

public class CubeLook : MonoBehaviour
{
    public GameObject child;
    public Vector3 startPos;

    public GameObject target;
    public Vector3 targetPos;
    void Start()
    {
        startPos = transform.position;
        child.transform.position = startPos + transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = target.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(targetPos, Vector3.forward);

        transform.rotation = rotation;
    }
}
