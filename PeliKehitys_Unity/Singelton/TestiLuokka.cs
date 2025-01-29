using UnityEngine;
using Singelton;
public class TestiLuokka : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(GameManager.Instance);
    }

}
