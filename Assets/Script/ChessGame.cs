using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessGame : MonoBehaviour
{
    public GameObject[] m_spawnPosition;
    public GameObject[] m_chess;
    
    void Start()
    {
        m_spawnPosition = GameObject.FindGameObjectsWithTag("ChessSpawn");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            int chessIndex = Random.Range(0, m_chess.Length);
            int posIndex = Random.Range(0, m_spawnPosition.Length);

            Debug.Log(chessIndex);
            Debug.Log(posIndex);

            Instantiate(m_chess[chessIndex], m_spawnPosition[posIndex].transform.position, Quaternion.identity);
        }
    }
}
