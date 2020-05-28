using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public void PrintInfo()
    {
        print(this);
    }

    public void DestroyWrapper()
    {
        Destroy(this.gameObject);
    }

    public void StartDestroyCoutdown()
    {
        Invoke("DestroyWrapper", 3);
    }
}
