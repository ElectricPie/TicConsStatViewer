using Import;
using UnityEngine;
using Newtonsoft.Json;

public class TicImport : MonoBehaviour
{
    [SerializeField] private string m_filePath = "";
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
            foreach (var mod in data.Infos.ModList)
            {
                Debug.Log($"Mod: {mod}");
            }
        }
        else
        {
            Debug.LogError("Infos is null.");
        }
    }
}

public class TicImportData
{
    [JsonProperty("infos")]
    public TicInfos Infos { get; set; }
    // public TicMaterial[] materials;
    // public TicTraits[] traits;
}