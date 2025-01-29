using UnityEngine;

[CreateAssetMenu(fileName = "Unit_", menuName = "Game Logic/Unit Stats")]
public class UnitStats : ScriptableObject
{
    public string emoji;
    public string description;

    public enum UnitType { Ranged, Melee, Cavalry, Support, Siege, Magic };
    public UnitType type;

    public int modelIndex = 0;

    public int baseHealth = 1;
    public int baseAttack = 1;
}
