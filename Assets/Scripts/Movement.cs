using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    public bool useInput;

    // Update is called once per frame
    void Update()
    {
        float input = useInput ? Input.GetAxis("Vertical") : 1f;
        transform.position += transform.forward * moveSpeed * input * Time.deltaTime;
    }
}
