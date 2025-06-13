using Import;
using TMPro;
using UnityEngine;

public class MaterialListElement : MonoBehaviour
{
    [SerializeField] private TMP_Text m_nameValueText;
    
    public void SetData(TicMaterial material)
    {
        if (material is null)
        {
            Debug.LogError("Received null material.");
            return;
        }
        
        m_nameValueText.text = material.Name;
    }
}
