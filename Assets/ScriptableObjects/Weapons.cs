using UnityEngine;

[CreateAssetMenu(fileName = "Weapons", menuName = "Scriptable Objects/Weapons")]
public class Weapons : ScriptableObject
{
    public string weaponName;

    public Type type;
    public enum Type 
    {
        Blade,
        Ranged,
        Blunt
    }

    public int damage;

    public float speed;
}
