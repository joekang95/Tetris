using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] tetrominoes;
    private GameObject next;
    public Transform point;

    void Start()
    {
        next = Instantiate(tetrominoes[Random.Range(0, tetrominoes.Length)], transform.position, Quaternion.identity);
        Check();
        Generate();
    }

    public void Generate()
    {
        next = Instantiate(tetrominoes[Random.Range(0, tetrominoes.Length)], transform.position, Quaternion.identity);
        next.GetComponent<TetrisBlock>().start = false;
        next.transform.position = point.position;
    }

    public void Next()
    {
        next.transform.position = this.transform.position;
        Check();
        next.GetComponent<TetrisBlock>().start = true;
        Generate();
    }

    private void Check()
    {
        switch (next.tag)
        {
            case "O":
                next.transform.position += new Vector3(-0.5f, 0.5f, 0);
                break;
            case "I":
                next.transform.position += new Vector3(0.5f, 0, 0);
                break;
            default:
                next.transform.position += new Vector3(0, 0.5f, 0);
                break;
        }
    }
}
