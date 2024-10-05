using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    
    public Transform cubeTransform;

    public Rigidbody rb;

    private void Start()
    {
        //theRG = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
