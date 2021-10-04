using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//enum ObstacleType
//{
//    None,
//    Big

//}
public class SpawnRandomObstacle : MonoBehaviour
{
    
    float timer;
    public float chance;

    public GameObject BigObstacle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rnd = Random.value;
        print(rnd);
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            if (rnd <= chance)
            {
                var prefab = Chooser();
                var newBlock = Instantiate(prefab);
                timer = 6;
            }
            else
                timer = 2;
        }
    }

    public GameObject Chooser()
    {
        print("random");
        //if (rnd == chance)
        return BigObstacle;
        
    }
}
