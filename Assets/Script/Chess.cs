using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chess : MonoBehaviour
{
    public GameObject[] m_Particles;
    // Start is called before the first frame update
  

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Map")
        {
            int index = Random.Range(0, m_Particles.Length);
           
            Debug.Log(collision.contacts[0].point);

            Vector3 vector = collision.contacts[0].point;
           

            Instantiate(m_Particles[index], vector, Quaternion.identity);
            Destroy(this.gameObject);
            
        }
        else if(collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
      
    }
}
