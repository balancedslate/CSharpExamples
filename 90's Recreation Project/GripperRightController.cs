using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GripperRightController : MonoBehaviour
{
    Animator animator;
    public float rightGripperSpeed;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += rightGripperSpeed * Vector3.right;
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
