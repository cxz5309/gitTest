using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingYoungWoo : MonoBehaviour
{
    int cnt = 0;
    void Start()
    {
        cnt++;
        StartCoroutine(coCnt());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator coCnt()
    {
        while (true)
        {
            cnt++;
            yield return new WaitForSeconds(1f);
            Debug.Log(cnt);
        }
    }
}
    
