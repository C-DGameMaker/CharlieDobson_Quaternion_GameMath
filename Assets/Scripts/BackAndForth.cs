using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public float speed;
    public float amplitude = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Mathf.Sin((Time.time * speed) * 2) * amplitude;
        transform.eulerAngles = new Vector3(0, offset, 0);
    }
}
