using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    GameObject m_enemy;
    LayerMask m_layerMask = 10;
    float m_shootRange = 10f;
    // Start is called before the first frame update
    void Start()
    {
        m_enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(m_enemy.transform.position, m_enemy.transform.forward);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 5, Color.red, 5f);
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.collider.gameObject.name);
            
        }
    }
}