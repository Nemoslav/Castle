using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgadeHolderManager : MonoBehaviour
{
    [Header("Upgrage Holder")]
    [SerializeField] private Transform _upgrageHolderPosition;
    [SerializeField] private GameObject _Upgrade;
    [SerializeField] private Upgrade[] _upgradeSO;

    [Header("Upgrage Parametrs")]
    [SerializeField] private GameObject[] _plantedUpgades;
    private int _cost;
    private Sprite _icon;


    private void Start()
    {
        _plantedUpgades = new GameObject[_upgradeSO.Length];

        for (int i = 0; i < _upgradeSO.Length; i++)
        {
            CreateUpgrade(i);
        }
    }

    private void CreateUpgrade(int i)
    {
        var upgrade = Instantiate(_Upgrade, _upgrageHolderPosition);

        _plantedUpgades[i] = upgrade;

        _icon = _upgradeSO[i].icon;
        _cost = _upgradeSO[i].cost;

        upgrade.GetComponentInChildren<SpriteRenderer>().sprite = _icon;
        upgrade.GetComponentInChildren<TMP_Text>().text = _cost.ToString();
    }
}
