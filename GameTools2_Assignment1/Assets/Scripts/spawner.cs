using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    [SerializeField] string[] tag;

    ObjectPooler m_ObjectPooler;

    private void Start()
    {
        m_ObjectPooler = ObjectPooler.Instance;
    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        GameObject go = m_ObjectPooler.SpawnFromPool(tag[Random.Range(0, tag.Length)], transform.position, transform.rotation);
    }
}
