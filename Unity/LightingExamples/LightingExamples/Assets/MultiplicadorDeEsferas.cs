using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicadorDeEsferas : MonoBehaviour
{
	public GameObject prefabEsfera;
	public int numEsferas;
	public float separacion;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numEsferas; i++)
		{
			Vector3 newPosition = transform.position;
			newPosition.x += -(numEsferas * separacion / 2f) + (i * separacion);
			newPosition.y += 1f;
			Instantiate(prefabEsfera, newPosition, Quaternion.identity);
		}
    }
}
