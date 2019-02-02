using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitingSpoon : MonoBehaviour
{
    public Transform bowl;
    public float offsetX;
    public float offsetY;
    public float speed = 5f;
    public float someVariableX = 1f;
    public float someVariableY = 1f;
    float alpha = 0f;

    private Sprite sprite;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
    }

    void Update()
    {
        if (!GameTimeHandler.GameIsPaused)
        {//transform.position = new Vector2(center.x + (semiMajor * Mathf.Sin(AngleX)),
         //                                 center.y + (semiMinor * Mathf.Cos(AngleY)));

            transform.position = new Vector2(bowl.position.x + offsetX + (someVariableX * Mathf.Sin(Mathf.Deg2Rad * alpha)),
                                             bowl.position.y + offsetY + (someVariableY * Mathf.Cos(Mathf.Deg2Rad * alpha)));
            alpha += speed * Time.deltaTime;//can be used as speed

            //transform.Rotate(speed * Vector3.up * Time.deltaTime);
        }
    }
}

// Reference: https://gamedev.stackexchange.com/questions/128141/how-to-orbit-an-object-around-another-object-in-an-oval-path-in-unity
