
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public Vector3 nuevaPosicion = new Vector3 (0.02f,0,0);

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoCubo();
    }

    void MovimientoCubo()
    {
        transform.position += nuevaPosicion;
    }



}
