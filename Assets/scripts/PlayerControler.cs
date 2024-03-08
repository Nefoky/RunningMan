using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    public int speed = 20;
    public float horizontal;
    public float vertical;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
     
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            transform.Translate(new Vector3(0,0,2) * Time.deltaTime * speed * vertical);
            transform.Rotate(new Vector3(0,7,0) * Time.deltaTime * speed * horizontal);

       

    }

    





}
