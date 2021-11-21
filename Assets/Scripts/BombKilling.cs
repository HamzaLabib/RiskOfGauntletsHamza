using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombKilling : MonoBehaviour
{
    int explodeRange = 2;
    Transform grid;
    Grid gridScript;

    /*public GameObject explodedEnemy;
    public Animator explosion;*/

    Animator effect;

    private void Awake()
    {
        grid = GameObject.Find("Grid").transform;
        gridScript = grid.GetComponent<Grid>();
    }

    private void Update()
    {
        DeleteTile();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag != "Indestructible")
        {
            /*if (collision.collider == explodedEnemy.GetComponent<Collider2D>())
                EnemyExploded();*/
            
            Destroy(collision.gameObject);
        }
            
    }
    void DeleteTile()
    {
        gridScript.GetComponent<GridMng>().DeleteTile(this.transform, explodeRange);
    }

    /*void EnemyExploded()
    {
        effect = Instantiate(explosion);
        effect.transform.position = explodedEnemy.transform.position;
    }*/
}
