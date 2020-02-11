using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public GameObject[] Thing;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(14.5f);
        GameObject eClone = Instantiate(Thing[Random.Range(0, Thing.Length)], transform.position, transform.rotation);

    }
        // Update is called once per frame
        void Update()
        {
        
        }
}
