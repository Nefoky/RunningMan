using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingHeight : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Height")) 
        {
            transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            Destroy(collision.gameObject);
        
        }

        if (collision.gameObject.CompareTag("Obsacles"))
        {
            transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
           

        }


    }
}
