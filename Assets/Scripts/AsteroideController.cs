using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float vitesseMinimale = 5f;
    public float vitesseMaximale = 10f;
    private float vitesse;

    void Start()
    {
        vitesse = Random.Range(vitesseMinimale, vitesseMaximale);
    }

    void Update()
    {
        transform.Translate(Vector2.down * vitesse * Time.deltaTime);

        if (transform.position.y < -5.75f)
        {
            Destroy(gameObject);
        }
    }
}
