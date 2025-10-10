using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    private MeshRenderer meshrenderer;
    [SerializeField] float speedofBackground = 1f;
    private void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
    }


    void Update()
    {
        meshrenderer.material.mainTextureOffset += new Vector2(speedofBackground * Time.deltaTime, 0f);
    }
}
