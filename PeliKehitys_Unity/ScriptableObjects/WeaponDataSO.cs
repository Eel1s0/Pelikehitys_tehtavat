using UnityEngine;
/// <summary>
/// Aseen tyyppi
/// </summary>
public enum WeaponType { Melee, Ranged, Magic }
/// <summary>
/// Scriptable objects
/// </summary>
[CreateAssetMenu(fileName = "NewWeapon", menuName = "Weapons/WeaponData")]
public class WeaponDataSO : ScriptableObject
{
    public string weaponName; // aseen nimi
    public WeaponType weaponType; // aseen tyyppi
    public string specialAbility; // erikoisominaisuus
    public int damage; // vahingon määrä
    public float range; // hyökkäysalue
    public Sprite icon; // aseen kuva

    [SerializeField]
    public GameObject weaponPrefabs; // Aseen prefabs
}