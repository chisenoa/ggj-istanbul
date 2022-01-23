using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody2D rb;
    public PlayerManager otherPlayer;
    public Button replayButton;

    private float speed = 10;
    public int move = 4;

    public bool isCollided;

    public Animator anim;
    private bool canMove;
    public bool isScale;
    public GameObject azrailsol, azrailsag;
    public float yatay = Input.GetAxis("Horrizontal");
    public bool inputlog;
    


    public void Awake()
    {
        isCollided = true;
    }
    public void Start()
    {
        anim = GetComponent<Animator>();
        inputlog = true;


    }

    void Update()
    {
        
        if (move < 0)
        {
            Time.timeScale = 0;
            replayButton.gameObject.SetActive(true);
        }
        if (isCollided && otherPlayer.isCollided)
        {
            canMove = true;
        }

        if (!canMove) return;

        var movement = Vector3.zero;
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            
            if(inputlog == true)
            {
                azrailsol.transform.position = new Vector3(azrailsol.transform.position.x + 0.54f, azrailsol.transform.position.y);
                azrailsag.transform.position = new Vector3(azrailsag.transform.position.x - 0.54f, azrailsag.transform.position.y);
                inputlog = false;
            }
            else
            {
                
                azrailsol.transform.position = new Vector3(azrailsol.transform.position.x - 0.54f, azrailsol.transform.position.y);
                azrailsag.transform.position = new Vector3(azrailsag.transform.position.x + 0.54f, azrailsag.transform.position.y);
                inputlog = true;

            }
           

           

            movement = Vector3.up * speed;
           
        }
        
        
        if (Input.GetKeyDown(KeyCode.A))
        {
           
            movement = Vector3.left * speed;


            if (inputlog == true)
            {
                azrailsol.transform.position = new Vector3(azrailsol.transform.position.x + 0.54f, azrailsol.transform.position.y);
                azrailsag.transform.position = new Vector3(azrailsag.transform.position.x - 0.54f, azrailsag.transform.position.y);
                inputlog = false;
            }
            else
            {

                azrailsol.transform.position = new Vector3(azrailsol.transform.position.x - 0.54f, azrailsol.transform.position.y);
                azrailsag.transform.position = new Vector3(azrailsag.transform.position.x + 0.54f, azrailsag.transform.position.y);
                inputlog = true;

            }


        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            

            movement = Vector3.down * speed;

            if (inputlog == true)
            {
                azrailsol.transform.position = new Vector3(azrailsol.transform.position.x + 0.54f, azrailsol.transform.position.y);
                azrailsag.transform.position = new Vector3(azrailsag.transform.position.x - 0.54f, azrailsag.transform.position.y);
                inputlog = false;
            }
            else
            {

                azrailsol.transform.position = new Vector3(azrailsol.transform.position.x - 0.54f, azrailsol.transform.position.y);
                azrailsag.transform.position = new Vector3(azrailsag.transform.position.x + 0.54f, azrailsag.transform.position.y);
                inputlog = true;

            }

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            
            movement = Vector3.right * speed;

            if (inputlog == true)
            {
                azrailsol.transform.position = new Vector3(azrailsol.transform.position.x + 0.54f, azrailsol.transform.position.y);
                azrailsag.transform.position = new Vector3(azrailsag.transform.position.x - 0.54f, azrailsag.transform.position.y);
                inputlog = false;
            }
            else
            {

                azrailsol.transform.position = new Vector3(azrailsol.transform.position.x - 0.54f, azrailsol.transform.position.y);
                azrailsag.transform.position = new Vector3(azrailsag.transform.position.x + 0.54f, azrailsag.transform.position.y);
                inputlog = true;
                inputlog = true;

            }


        }

        //..

        if (movement.magnitude > .1f)
        {
            move = move - 1;
            isCollided = false;
            canMove = false;
            rb.velocity = movement;
            if (Mathf.Abs(movement.x) < .1f)
            {
                anim.SetTrigger("LeftSwipeV");
            }
            else
            {
                anim.SetTrigger("LeftSwipeV");
            }
            if (Mathf.Abs(movement.y) < .1f)
            {
                anim.SetTrigger("LeftSwipeH");
            }
            else
            {
                anim.SetTrigger("LeftSwipeH");
            }
        }
        
        
        



    }
    
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        isCollided = true;
    }
    /*
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "portal")
        {

        }
    }
    */
   
}
