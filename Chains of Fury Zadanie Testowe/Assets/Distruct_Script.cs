using UnityEngine;

public class Distruct_Script : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("collision");
        Destroy(gameObject);

    }

}
