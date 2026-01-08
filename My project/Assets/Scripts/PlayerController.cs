using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public static float moveInput;
    private float moveInputtwo;
    private Rigidbody2D rb;
    private bool m_FacingRight = true;
    private Vector2 move;
    private Vector2 mosPos;
    void Start () 
	{
        rb = GetComponent<Rigidbody2D>();
	}

	void Update () 
	{
        //mosPos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        /*if (Input.GetKey (KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2 (-moveSpeed, 0);
        }
        if (Input.GetKey (KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSpeed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeedtwo, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeedtwo, 0);
        }*/
        rb.velocity = moveInput * moveSpeed;
       /* if(moveInput != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, moveInput);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }*/
    }
    void FixedUpdate()
    {
        /*Vector2 rot = mosPos - rb.position;
        float angle = Mathf.Atan2(rot.y, rot.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        moveInput = Input.GetAxis("Vertical");
        moveInputtwo = Input.GetAxis("vertical");
        Debug.Log(moveInput);
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        rb.velocity = new Vector2(moveInputtwo * moveSpeedtwo, rb.velocity.x);
        if (m_FacingRight == false && moveInput > 0){
            Flip();
        }else if (m_FacingRight == true && moveInput < 0){
            Flip();
        }*/
    }

    void Flip()
    {
        m_FacingRight = !m_FacingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}