using UnityEngine;
using UnityEngine.InputSystem;

public class TestiController : MonoBehaviour
{
    [SerializeField] private GameObject Mage;
    [SerializeField] private GameObject Warrior;

    private void Update()
    {
        var gKey = Keyboard.current.gKey.wasPressedThisFrame;
        var hKey = Keyboard.current.hKey.wasPressedThisFrame;
        var yKey = Keyboard.current.yKey.wasPressedThisFrame;
        var tKey = Keyboard.current.tKey.wasPressedThisFrame;


        if (gKey)
        {
            Mage.GetComponent<Mage>().TakeDamage(5);
        }

        if (hKey) 
        {
            Warrior.GetComponent<Warrior>().TakeDamage(3);
        }

        if (yKey) 
        {
            Mage.GetComponent<Mage>().Attack();
        }

        if (tKey) 
        {
            Warrior.GetComponent<Warrior>().Attack();
        }
    }
}
