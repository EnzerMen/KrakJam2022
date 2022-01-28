using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// [RequireComponent(typeof(BoxCollider2D))] 
// ^ jesli to jest, to collider sam siê zrobi jeœli go nie ma, bez tego bêdzie error jeœli go nie bêdzie
public class Collidable : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10];



    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    protected virtual void Update()
    {
        //collision
        boxCollider.OverlapCollider(filter, hits);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
                continue;

            OnCollide(hits[i]);

            hits[i] = null;


        }

    }


    protected virtual void OnCollide(Collider2D coll)
    {
        Debug.Log("OnCollide was not implemented in " + this.name);
    }
}
