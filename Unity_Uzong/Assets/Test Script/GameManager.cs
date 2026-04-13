using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn (GameObject _obj)
    {
        int randomX = Random.Range(1, 11); // 1~10 사이의 무작위 정수값
        int randomZ = Random.Range(1, 11); // 1~10 사이의 무작위 정수값
        transform.position = new Vector3(randomX, 0, randomZ);
    }
}
