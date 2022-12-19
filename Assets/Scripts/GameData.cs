using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{

    [System.Serializable]
    public struct CountryData
    {
        public string Name;
        public Sprite Flag;
        public bool Guessed;
        public bool BeenQuestioned;
    }

    public CountryData[] EuropeanCountryDatSet;
    public CountryData[] AsiaCountryDatSet;
    public CountryData[] AfricaCountryDatSet;
    public CountryData[] NorthAmericaCountryDatSet;
    public CountryData[] SouthAmericaCountryDatSet;
    public CountryData[] OceniaCountryDatSet;

    [HideInInspector]
    public CountryData[] CountrySetPerGame;
    [HideInInspector]
    public CountryData[] CountryDataSet;

    public static GameData Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
