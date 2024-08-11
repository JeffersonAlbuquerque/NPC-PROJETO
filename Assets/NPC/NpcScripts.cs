using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcScripts : MonoBehaviour
{
    private GameObject group;

    // Start is called before the first frame update
    void Start()
    {
        // Cria um GameObject vazio para servir como grupo
        group = new GameObject("CubeGroup");

        // Criando uma figura de Steve do Minecraft usando Cubos
        GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = new Vector3(0, 0, 0);
        cube1.transform.parent = group.transform;

        GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.transform.position = new Vector3(-0.5f, 1, 0);
        cube2.transform.parent = group.transform;

        GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube3.transform.position = new Vector3(0.5f, 1, 0);
        cube3.transform.parent = group.transform;

        GameObject cube4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube4.transform.position = new Vector3(0.5f, 2, 0);
        cube4.transform.parent = group.transform;

        GameObject cube5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube5.transform.position = new Vector3(-0.5f, 2, 0);
        cube5.transform.parent = group.transform;

        GameObject cube6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube6.transform.position = new Vector3(0, 3, 0);
        cube6.transform.parent = group.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Movimenta o grupo ao longo do eixo X
        group.transform.position += new Vector3(0.01f, 0, 0);
    }
}