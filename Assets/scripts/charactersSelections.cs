using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class charactersSelections : MonoBehaviour
{
    public GameObject optionPrefab;
    public Transform prevCharacter;
    public Transform selectedCharacter;
    private void Start()
    {
        foreach (ClassCharaters c in gameManager.instance.characters)
        {
            GameObject option = Instantiate(optionPrefab, transform);
            Button button = option.GetComponent<Button>();

            button.onClick.AddListener(() =>
            {
                gameManager.instance.SetCharacter(c);
                if (selectedCharacter != null)
                {
                    prevCharacter = selectedCharacter;
                }

                selectedCharacter = option.transform;
            });

            TextMeshProUGUI text = option.
            GetComponentInChildren<TextMeshProUGUI>();
            text.text = c.name;

            Image image = option.GetComponentInChildren<Image>();
            image.sprite = c.image;
        }
    }

    private void Update()
    {
        if (selectedCharacter != null)
        {
            selectedCharacter.localScale = Vector3.Lerp(selectedCharacter.localScale, new Vector3(1.2f, 1.2f, 1.2f), Time.deltaTime * 10);
        }

        if (prevCharacter != null)
        {
            prevCharacter.localScale = Vector3.Lerp(prevCharacter.localScale, new Vector3(1.0f, 1.0f, 1.0f), Time.deltaTime * 10);
        }
    }
}
