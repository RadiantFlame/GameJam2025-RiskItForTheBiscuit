using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SlotMachine : MonoBehaviour
{
    public UnityEngine.UI.Image[] Slots;
    public Sprite[] Ingredients;
    public UnityEngine.UI.Button SpinLever;

    private void Start()
    {
       // InvokeRepeating("DoThing", 1.0f, 0.1f);
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    public void SpinWheels()
    {
        for (int i = 0; i < Slots.Length; i++)
        {
            Slots[i].sprite = Ingredients[Random.Range(0, 4)];
        }
    }

    void DoThing()
    {
        for (int i = 0; i < Slots.Length; i++) {
            Slots[i].sprite = Ingredients[Random.Range(0,4)];
        }
    }
}
