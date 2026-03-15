using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public float speed = 5f;
    public float rotationSpeed = 10f;

    public int playerHealth = 100;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0f, moveZ);

        if (move.magnitude > 0.1f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(move);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            animator.SetFloat("walk", 0.5f);
        }
        else
        {
            animator.SetFloat("walk", 0.0f);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jump");
        }

        transform.Translate(move * speed * Time.deltaTime, Space.World);
    }
}