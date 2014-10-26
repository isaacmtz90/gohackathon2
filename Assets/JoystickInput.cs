using UnityEngine;
using System.Collections;

public class JoystickInput : MonoBehaviour {
    
    public Joystick joystick;           // Reference to joystick prefab
    public float speed = 10;             // Movement speed
    public bool useAxisInput = true;   // Use Input Axis or Joystick
    private float h = 0, v = 0;         // Horizontal and Vertical values
    public Animator animator;
    //private SpriteRenderer[] renderers;

    void Start(){
        animator = GetComponent<Animator>();    
//        renderers = GetComponentsInChildren<SpriteRenderer>();
    }
    // Update is called once per frame
    void FixedUpdate () {
        // Get horizontal and vertical input values from either axis or the joystick.
        if (!useAxisInput) {
            h = joystick.position.x;
            v = joystick.position.y;
        }
        else {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
        }
        
        // Apply horizontal velocity
        if (Mathf.Abs(h) > 0) {
            rigidbody2D.velocity = new Vector2(h * speed, rigidbody2D.velocity.y);
            //facing right? ;left?
            //Debug.Log (h);
            if(h>0){
                //Moving right:
                animator.SetBool("FacingRight",true);
            }
            if(h<0){
                //Moving left:
                //animator.SetBool("FacingLeft",true);
                animator.SetBool("FacingRight",true);
            }
        
        }
        
        // Apply vertical velocity
        if (v> 0) {
            //Debug.Log(v);
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, v * speed);
        }
        if (v< 0) {
            //Debug.Log(v);
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, v * speed*2);
        }
        if (Mathf.Abs (v) == 0 && Mathf.Abs (h)==0) {
            animator.SetBool("Idle",true);
            animator.SetBool("FacingRight",false);
            //animator.SetBool("FacingLeft",false);
            }

    }
}