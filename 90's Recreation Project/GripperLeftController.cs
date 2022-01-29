using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GripperLeftController : MonoBehaviour
{
    Animator animator;
    public float leftGripperSpeed;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += leftGripperSpeed * Vector3.left;
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
