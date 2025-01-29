using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private UnitStats stats;

    [SerializeField] private GameObject[] headParts;
    [SerializeField] private GameObject[] bodyParts;

    private void Awake()
    {
        headParts[stats.headIndex].SetActive(true);
        bodyParts[stats.bodyIndex].SetActive(true);
    }
}
