using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStream : MonoBehaviour
{
    public void OpenTheStream()
    {
        System.Diagnostics.Process.Start("https://www.google.com/");
    }
}
