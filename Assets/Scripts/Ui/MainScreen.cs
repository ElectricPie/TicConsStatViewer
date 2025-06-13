using Import;
using TMPro;
using UnityEngine;

public class MainScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text m_sourceValueText;
    [SerializeField] private GameObject m_materialScrollViewContent;
    [SerializeField] private GameObject m_materialUiPrefab;
    
    private TicImportData m_data;

    public void SetData(TicImportData inData)
    {
        if (inData is null)
        {
            Debug.LogError("Received null data.");
            return;
        }

        if (inData.Infos is not null)
        {
            m_sourceValueText.text = inData.Infos.Source;
        }

        if (inData.Materials is not null)
        {
            foreach (TicMaterial material in inData.Materials.Values)
            {
                if (material is null)
                {
                    Debug.LogError("Found null material in the data.");
                    continue;
                }

                MaterialListElement newMaterial = Instantiate(m_materialUiPrefab, m_materialScrollViewContent.transform).GetComponent<MaterialListElement>();
                newMaterial.SetData(material);
            }
        }
        else
        {
            Debug.LogError("Materials is null in the provided data.");
        }
    }
}
