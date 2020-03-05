using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMov : MonoBehaviour
{
    public int cambio;
    public GameObject cubo;

    void Start()
    {
        StartCoroutine(Mover());
    }
  
    IEnumerator Mover()
    {
        while (true)
        {
            cambio = Random.Range(0,5);
           
            yield return new WaitForSeconds(5);
        }
    }
    public void Estados()
    {
         switch (cambio)
            {
                case 0:
                transform.position += transform.forward * 1 *Time.deltaTime;
                break;
                case 1:
                transform.position+= transform.up * 1*Time.deltaTime;
                break;
                case 2:
                transform.position -= transform.forward *1*Time.deltaTime;
                break;
                case 3:
                transform.position -= transform.up * 1*Time.deltaTime;
                break;
                case 4:
                transform.position += transform.right * 1 *Time.deltaTime;
                break;
                case 5:
                transform.position -= transform.right *1 *Time.deltaTime;
                break;
                default:
                break;
            }
    }
    void Update()
    {
        Estados();
        cubo.transform.position = new Vector3(transform.position.x, cubo.transform.position.y, transform.position.z);
    }
}
