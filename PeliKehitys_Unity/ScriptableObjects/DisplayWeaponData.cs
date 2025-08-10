using TMPro;
using UnityEngine;
/// <summary>
/// N‰ytt‰‰ aseen tiedot UIssa
/// </summary>
public class DisplayWeaponData : MonoBehaviour
{
    public static DisplayWeaponData Instance { get; private set; }
    public TMP_Text nameText;
    public TMP_Text weaponText;
    public GameObject weaponPanelUI;
    private void Awake()
    {
        Instance = this;
    }
    // N‰ytt‰‰ aseen tiedot panelissa
    public void ShowWeaponData(WeaponDataSO weaponData)
    {
        weaponPanelUI.SetActive(true);
        nameText.text = weaponData.name;
        string text = $"Vahinko: {weaponData.damage}, Tyyppi: { weaponData.weaponType}, " + $"Alue: {weaponData.range}, Erikoisominaisuus: { weaponData.specialAbility}";
        weaponText.text = text;
    }
    public void ClosePanel()
    {
        weaponPanelUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}