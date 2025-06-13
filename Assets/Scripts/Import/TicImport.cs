using System.Collections.Generic;
using System.Linq;
using Import;
using UnityEngine;
using Newtonsoft.Json;

public class TicImport : MonoBehaviour
{
    // [SerializeField] private string m_filePath = "";
    [SerializeField] private TextAsset m_jsonFile = null;

    public void Start()
    {
        if (m_jsonFile is null)
            return;

        // TicImportData data = JsonUtility.FromJson<TicImportData>(m_jsonFile.text);
        TicImportData data = JsonConvert.DeserializeObject<TicImportData>(m_jsonFile.text);
        if (data is null)
        {
            Debug.LogError("Failed to parse JSON data.");
            return;
        }

        if (data.Infos is not null)
        {
            Debug.Log($"Infos: {data.Infos}");
            // foreach (var mod in data.Infos.ModList)
            // {
            //     Debug.Log($"Mod: {mod}");
            // }
        }
        else
        {
            Debug.LogError("Infos is null.");
        }

        if (data.Materials is not null)
        {
            //const int testCountMax = 10;
            //int testCount = data.Materials.Keys.Count < testCountMax ? data.Materials.Keys.Count : testCountMax;
            //for (int i = 0; i < testCount; i++)
            
            // for (int i = 0; i < data.Materials.Keys.Count; i++)
            // {
            //     // Accessing the dictionary by key
            //     string key = data.Materials.Keys.ElementAt(i);
            //     TicMaterial material = data.Materials[key];
            //     // Debug.Log($"Material {key}: {material}");
            //     if (material.Fletching is not null)
            //     {
            //         Debug.Log($"Material {key}: Fletching {material.Fletching}");
            //     }
            // }
        }
        else
        {
            Debug.LogError("Materials is null.");
        }

        if (data.Traits is not null)
        {
            // const int testCountMax = 3;
            // int testCount = data.Traits.Keys.Count < testCountMax ? data.Traits.Keys.Count : testCountMax;
            for (int i = 0; i < data.Traits.Keys.Count; i++)
            {
                // Accessing the dictionary by key
                string key = data.Traits.Keys.ElementAt(i);
                TicTraits trait = data.Traits[key];
                Debug.Log($"Trait {key}: {trait}");
            }
        }
        else
        {
            Debug.LogError("Traits is null.");
        }
    }
}

public class TicImportData
{
    [JsonProperty("infos")]
    public TicInfos Infos { get; set; }
    [JsonProperty("materials")]
    public Dictionary<string, TicMaterial> Materials { get; set; }
    [JsonProperty("traits")]
    public Dictionary<string, TicTraits> Traits { get; set; }
}