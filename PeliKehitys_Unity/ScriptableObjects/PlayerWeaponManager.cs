using UnityEngine;
/// <summary>
/// Aseen hallinta
/// </summary>
public class PlayerWeaponManager : MonoBehaviour
{
    // Nykyinen ase (pakollinen)
    public Weapon3 currentWeapon;
    // Aseen sijainti
    public Transform weaponPosition;
    // pelaajan aseen kopio
    private GameObject weapon;
    private void Start()
    {
        // Aseistaa pelaajan pelin alussa oletusaseella
        EquipWeapon(currentWeapon.weaponData);
    }
    public void EquipWeapon(WeaponDataSO newWeaponData)
    {
        // Poistetaan edellinen ase jos sellainen on
        if (weapon != null) { Destroy(weapon); }
        // Tarkistaa että pelaajalla on vähintään oletusase
        if (currentWeapon != null)
        {
            // Vaihtaa nykyisen aseen asedatan
            currentWeapon.weaponData = newWeaponData;
            Debug.Log("Aseistettu: " + currentWeapon.weaponData.weaponName); //newWeaponData.weaponName);
            // Sijoitetaan aseen kopio pelaajalle
            weapon = Instantiate(currentWeapon.weaponData.weaponPrefabs,
            weaponPosition);
        }
        else // Oletusase puuttuu
        {
            Debug.LogWarning("Oletus ase puuttuu!");
        }
    }
    void Update()
    {
        // Aseella tehtävä hyökkäys
        if (Input.GetKeyDown(KeyCode.Space) && currentWeapon)
        {
            currentWeapon.Attack();
        }
    }
}