using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Orbit : MonoBehaviour
{
    public GameObject child;
    public float time = 0.0f;
    public float speed;

    public Transform startPos;
    public GameObject orbitObject;
    void Start()
    {
        child.transform.position = transform.position + transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        transform.rotation = Quaternion.Slerp(startPos.rotation, Quaternion.LookRotation(orbitObject.transform.position - transform.position), time);
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
