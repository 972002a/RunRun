using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chess : MonoBehaviour
{
    public GameObject[] m_Particles;
    // Start is called before the first frame update
    public GameObject[] m_playerParticles;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int index = Random.Range(0, m_playerParticles.Length);
            Instantiate(m_playerParticles[index], collision.contacts[0].point, Quaternion.identity);
            collision.gameObject.GetComponent<Player>().SetState_Die();
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Map")
        {
            int index = Random.Range(0, m_Particles.Length);
           
            Instantiate(m_Particles[index], collision.contacts[0].point, Quaternion.identity);
            Destroy(this.gameObject);
            
        }
        
        
      
    }
}
