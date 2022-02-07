using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{

    bool mov = true;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") && mov)
        {
            i = 0;
            mov = false;
            this.transform.position = new Vector3(this.transform.position.x+3, this.transform.position.y, this.transform.position.z);
        }
        if (Input.GetKey("w") && mov)
        {
            mov = false;
            i = 1;
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 3, this.transform.position.z);
        }
        if (Input.GetKey("a") && mov)
        {
            mov = false;
            i = 2;
            this.transform.position = new Vector3(this.transform.position.x - 3, this.transform.position.y, this.transform.position.z);
        }
        if (Input.GetKey("s") && mov)
        {
            mov = false;
            i = 3;
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 3, this.transform.position.z);
        }

        if ((Input.GetKeyUp("d") && i == 0) || (Input.GetKeyUp("s") && i == 3) || (Input.GetKeyUp("w") && i == 1) || (Input.GetKeyUp("a") && i == 2))
        {
            mov = true;
        }
    }
}
