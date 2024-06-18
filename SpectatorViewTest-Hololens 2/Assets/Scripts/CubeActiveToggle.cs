using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeActiveToggle : MonoBehaviour
{
    // Start is called before the first frame update
    public void CubeToggle()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
