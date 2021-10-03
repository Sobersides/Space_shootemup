using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public List<GameObject> asteroids;
    public GameObject Waypoint1;
    public GameObject Waypoint2;
    public float SpawnTime;
    public float MoveSpeed;

    private float spawnTimer;
    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = SpawnTime;
        target = Waypoint1;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer < 0)
        {
            // Skip spawn some of the time
            var index = Random.Range(0, asteroids.Count + 1);
            if(index < asteroids.Count)
            {
                Instantiate(asteroids[index], transform.position, Quaternion.identity);
                spawnTimer = SpawnTime;
            }
        }

        var toWaypoint = target.transform.position - transform.position;
        if(toWaypoint.magnitude < .2)
        {
            if(target == Waypoint1)
            {
                target = Waypoint2;
            }
            else
            {
                target = Waypoint1;
            }
        }
        var direction = toWaypoint.normalized;
        var moveTowardsStep = direction * MoveSpeed * Time.deltaTime;
        transform.Translate(moveTowardsStep);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 1);
    }
}
