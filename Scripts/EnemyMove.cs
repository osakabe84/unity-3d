using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Vector3[] enemytails = {new Vector3(2, 0, 1), new Vector3(3, 0, 1), new Vector3(4, 0, 1),
                          new Vector3(2, 0, 0), new Vector3(3, 0, 0), new Vector3(4, 0, 0),
                          new Vector3(2, 0, -1), new Vector3(3, 0, -1),new Vector3(4, 0, -1)};
    GameObject m_player;
    float m_timer;
    public float m_cooltime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        m_player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        int enemypos = Array.IndexOf(enemytails, transform.position);
        m_timer += Time.deltaTime;
        if (m_player)
        {
            if (m_timer > m_cooltime)
            {
                if (m_player.transform.position.z == 0 && enemypos > 5)
                {
                    transform.position = enemytails[enemypos - 3];
                    m_timer = 0;
                }
                else if (m_player.transform.position.z == 0 && enemypos < 3)
                {
                    transform.position = enemytails[enemypos + 3];
                    m_timer = 0;
                }
                if (m_player.transform.position.z == 1)
                {
                    transform.position = enemytails[enemypos - 3];
                    m_timer = 0;
                }
                if (m_player.transform.position.z == -1)
                {
                    transform.position = enemytails[enemypos + 3];
                    m_timer = 0;
                }
            }
        }
    }
}
